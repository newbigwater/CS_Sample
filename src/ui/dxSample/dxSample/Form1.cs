using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        class Customer {
            public int Id { get; set; }
            public string Name { get; set; }
            public Image Image { get; set; }
        }

        static SemaphoreSlim _Lock = new SemaphoreSlim(1, 1);
        public Form1() {
            InitializeComponent();
            tileView1.OptionsImageLoad.AsyncLoad = true;
            tileView1.OptionsImageLoad.DesiredThumbnailSize = new Size(32, 32);
            this.Shown += Form1_Shown;
        }
        private async void Form1_Shown(object sender, EventArgs e) {
            await LoadDataAsync();
        }
        private void tileView1_GetThumbnailImage(object sender, DevExpress.Utils.ThumbnailImageEventArgs e) {
            int rh = tileView1.GetRowHandle(e.DataSourceIndex);
            e.ThumbnailImage = e.CreateThumbnailImage(this.imageCollection1.Images[0]);
        }
        public async Task LoadDataAsync() {
            await _Lock.WaitAsync(); //SemaphoreSlim to prevent multiple access to this method
            try {
                var data = await GetDataAsync();
                gridControl1.BeginInvoke(new Action(() => {
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = data.ToArray();
                }));
            }
            finally {
                _Lock.Release();
            }
        }
        async Task<List<Customer>> GetDataAsync() {
            return await Task.Run(() => CreateCustomers());
        }
        List<Customer> CreateCustomers() {
            List<Customer> list = new List<Customer>();
            for(int i = 0; i < 1000000; i++) {
                list.Add(new Customer() { Id = i, Name = "Name" + i });
            }
            return list;
        }
    }
}

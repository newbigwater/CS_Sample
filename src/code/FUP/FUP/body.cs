using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FUP
{
    /// <summary>
    /// 파일 전송 요청 메시지(0x01)에 사용할 본문 클래스입니다.
    /// FILESIZE와 FILENAME 필드를 가집니다.
    /// </summary>
    public class BodyRequest : ISerializable
    {
        public long FILESIZE;
        public byte[] FILENAME;

        public BodyRequest() { }

        public BodyRequest(byte[] bytes)
        {
            FILESIZE = BitConverter.ToInt16(bytes, 0);
            FILENAME = new byte[bytes.Length - sizeof(long)];
            Array.Copy(bytes, sizeof(long), FILENAME, 0, FILENAME.Length);
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            byte[] temp = BitConverter.GetBytes(FILESIZE);
            Array.Copy(temp, 0, bytes, 0, temp.Length);

            Array.Copy(FILENAME, 0, bytes, temp.Length, FILENAME.Length);

            return bytes;
        }

        public int GetSize()
        {
            return sizeof(long) + FILENAME.Length;
        }
    }

    /// <summary>
    /// 파일 전송 요청에 대항 응답(0x02)에 사용할 본문 클래스입니다.
    /// MSGID, RESPONSE 필드를 가집니다.
    /// </summary>
    public class BodyResponse : ISerializable
    {
        public uint MSGID;
        public byte RESPONSE;
        
        public BodyResponse() { }

        public BodyResponse(byte[] bytes)
        {
            MSGID = BitConverter.ToUInt32(bytes, 0);
            RESPONSE = bytes[sizeof(uint)];
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            byte[] temp = BitConverter.GetBytes(MSGID);
            Array.Copy(temp, 0, bytes, 0, temp.Length);

            bytes[temp.Length] = RESPONSE;

            return bytes;
        }

        public int GetSize()
        {
            return sizeof(uint) + sizeof(byte);
        }
    }

    /// <summary>
    /// 실제 파일을 전송하는 메시지(0x03)에 사용할 본문 클래스입니다.
    /// 앞서 프로토콜 정의에서 이야기 했던 것처럼 DATA 필드만 갖고 있습니다.
    /// </summary>
    public class BodyData : ISerializable
    {
        public byte[] DATA;

        public BodyData(byte[] bytes)
        {
            DATA = new byte[bytes.Length];
            bytes.CopyTo(DATA, 0);
        }


        public byte[] GetBytes()
        {
            return DATA;
        }

        public int GetSize()
        {
            return DATA.Length;
        }
    }

    /// <summary>
    /// 파일 전송 결과 메시지(0x04)에 사용할 본문 클래스입니다.
    /// 요청 메시지의 MSGID와 성공 여부를 나타내는 RESULT 프로퍼티를 가집니다.
    /// </summary>
    public class BodyResult : ISerializable
    {
        public uint MSGID;
        public byte RESULT;

        public BodyResult() { }

        public BodyResult(byte[] bytes)
        {
            MSGID = BitConverter.ToUInt32(bytes, 0);
            RESULT = bytes[4];
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            byte[] temp = BitConverter.GetBytes(MSGID);
            Array.Copy(temp, 0, bytes, 0, temp.Length);

            bytes[temp.Length] = RESULT;

            return bytes;
        }

        public int GetSize()
        {
            return sizeof(uint) + sizeof(byte);
        }
    }
}

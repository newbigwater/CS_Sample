// ClassLib.h

#pragma once

using namespace System;

class StaticLib;
namespace ClassLib {

	public ref class WrapStaticLib
	{
	protected:
		StaticLib* m_pStaticLib;

	public :
		WrapStaticLib();
		virtual ~WrapStaticLib();

		int Add(int a, int b);
	};
}

extern "C" {
	__declspec(dllexport) int AddTest1(int a, int b);
}

extern "C" __declspec(dllexport) int AddTest2(int a, int b, int c)
{
	return a + b + c;
}
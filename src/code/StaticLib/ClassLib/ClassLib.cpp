// 기본 DLL 파일입니다.

#include "stdafx.h"
#include "..\StaticLib\StaticLib.h"
#pragma comment(lib, "StaticLib.lib")
#include "ClassLib.h"

ClassLib::WrapStaticLib::WrapStaticLib()
	: m_pStaticLib(new StaticLib)
{

}

ClassLib::WrapStaticLib::~WrapStaticLib()
{
	if (m_pStaticLib)
		delete m_pStaticLib;
	m_pStaticLib = 0;
}

int ClassLib::WrapStaticLib::Add(int a, int b)
{
	return m_pStaticLib->Add(a, b);
}

int AddTest1(SHORT a, int b)
{
	return a + b + 1;
}

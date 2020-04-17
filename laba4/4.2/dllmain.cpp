// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"

using namespace std;

__declspec (dllexport)
extern "C" __declspec(dllexport) int __stdcall Add(int a, int b) 
{
	return a + b;
}
extern "C" __declspec(dllexport) int __stdcall Sub(int a, int b)
{
	return a - b;
}

extern "C" __declspec(dllexport) double Av(double a, double b)
{
	return (a + b) / 2;
}


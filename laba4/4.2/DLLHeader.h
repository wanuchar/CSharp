#pragma once
#ifdef DLL_EXPORTS
#define DLL_API __declspec(dllexport)
#else
#define DLL_API __declspec(dllimport)
#endif // DLL_EXPORTS

extern "C" DLL_API int Add(int a, int b);
extern "C" DLL_API int Sub(int a, int b);
extern "C" DLL_API double Av(double a, double b);

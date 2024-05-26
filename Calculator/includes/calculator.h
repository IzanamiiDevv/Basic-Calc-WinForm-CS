#ifndef CALCULATOR_H
#define CALCULATOR_H

#ifdef _WIN32
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT
#endif

extern "C" {
    namespace Op
    {
        int add(int x, int y);
        int sub(int x, int y);
        int mul(int x, int y);
        int divd(int x, int y);
        int mod(int x, int y);
    }
}

#endif

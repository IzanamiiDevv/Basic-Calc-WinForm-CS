#include <iostream>
#include <string>
#include <cctype>
#include "./includes/cli.h"
#include "./includes/calculator.h"

void calculate(int x, int y, std::string op);
std::string toLower(const std::string& str);

int main(int argc, char* argv[]){
    int x = CLI::scan_int("-x", argc, argv);
    int y = CLI::scan_int("-y", argc, argv);

    std::string oper = CLI::scan_string("-operator", argc, argv);
    std::string op = CLI::scan_string("-op", argc, argv);

    calculate(x, y, (op != "") ? op : oper);

    return 0;
}

void calculate(int x, int y, std::string op){
    if(toLower(op) == "add"){
        std::cout << Op::add(x,y) << '\n';
        return;
    }

    if(toLower(op) == "addition"){
        std::cout << Op::add(x,y) << '\n';
        return;
    }

    if(toLower(op) == "plus"){
        std::cout << Op::add(x,y) << '\n';
        return;
    }

    if(toLower(op) == "sub"){
        std::cout << Op::sub(x,y) << '\n';
        return;
    }

    if(toLower(op) == "subtraction"){
        std::cout << Op::sub(x,y) << '\n';
        return;
    }

    if(toLower(op) == "minus"){
        std::cout << Op::sub(x,y) << '\n';
        return;
    }

    if(toLower(op) == "mul"){
        std::cout << Op::mul(x,y) << '\n';
        return;
    }

    if(toLower(op) == "multiplication"){
        std::cout << Op::mul(x,y) << '\n';
        return;
    }

    if(toLower(op) == "multiply"){
        std::cout << Op::mul(x,y) << '\n';
        return;
    }

    if(toLower(op) == "div"){
        std::cout << Op::divd(x,y) << '\n';
        return;
    }

    if(toLower(op) == "divide"){
        std::cout << Op::divd(x,y) << '\n';
        return;
    }

    if(toLower(op) == "division"){
        std::cout << Op::divd(x,y) << '\n';
        return;
    }

    if(toLower(op) == "mod"){
        std::cout << Op::mod(x,y) << '\n';
        return;
    }

    if(toLower(op) == "modolus"){
        std::cout << Op::mod(x,y) << '\n';
        return;
    }

    std::cout << "Cant calculate the values no operator assigned" << '\n';
}

std::string toLower(const std::string& str) {
    std::string result;
    for (char c : str) {
        result += std::tolower(c);
    }
    return result;
}
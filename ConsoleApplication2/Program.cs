using System;
using System.Collections.Generic;
using static ConsoleApplication2.LexerTypes;

namespace ConsoleApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lexer lexer = new Lexer();
            List<Token> tokens = lexer.Parse("input.swift");
            Console.WriteLine($"tokens.size() {tokens.Count}");
            foreach (Token token in tokens)
            {
                Console.WriteLine($"[{token.status}][{token.line}:{token.position}] {token.value}");
            }
            Console.ReadKey();
        }
    }
}
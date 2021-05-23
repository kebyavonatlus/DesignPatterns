﻿using static System.Console;

namespace Builder
{

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");

            WriteLine(builder);

        }
    }
}

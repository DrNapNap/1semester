﻿using System;

namespace semester_1
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new GameWorld())
                game.Run();
        }
    }
}

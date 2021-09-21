using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace MusicProj
{
    class Program
    {



        static void Main(string[] args)
        {
            var song1 = "246 250 293 250 370 250 293 250 246 250 370 250 293 250 246 250 220 250 277 250 370 250 277 250 220 250 370 250 277 250 220 250 196 250 246 250 370 250 246 250 196 250 392 250 246 250 196 250 440 250 246 250 196 250 392 250 246 250 196 250 370 250 246 250";
            var song2 = "123 250 185 250 246 250 246 250 123 500 370 250 246 250 329 250 165 250 220 250 370 250 123 500 123 500 93 250 165 250 246 250 246 250 93 500 293 500 110 250 370 250 196 250 329 250 110 500 110 500 123 250 185 250 246 250 246 250 123 500 370 250 246 250 329 250 165 250 220 250 370 250 123 500 123 500 93 250 165 250 246 250 246 250 93 500 293 500 329 250 196 250 370 250 329 250 110 500 110 500";
            Play(song1);
            Play(song1);
            Play(song2);
         
          
        }




        static void Play(string sounds)
        {
            var nums = sounds.Split(" \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i += 2)
            {
                if (nums[i] == 0)
                {
                    Thread.Sleep(nums[i + 1]);
                }
                else
                {
                    Console.Beep(nums[i], nums[i + 1]);
                }
            }
        }
    }
}

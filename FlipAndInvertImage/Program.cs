using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipAndInvertImage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] image1 = new int[][]
            {
                new int[] {1,1,0},
                new int[] {1,0,1},
                new int[] {0,0,0},
            };
            foreach (var item in image1)
            {
                Console.WriteLine(String.Join(",", item));
            }
            Console.WriteLine($"\n--------------------------------------------------------");
            Console.WriteLine("FLIPPED\n");

            var newImage1 = FlipAndInvertImage(image1);
            foreach (var item in newImage1)
            {
                Console.WriteLine(String.Join(",", item));
            }
            Console.WriteLine($"\n--------------------------------------------------------\n");
            //-----------------------------------------------------------------------------------
            int[][] image2 = new int[][]
            {
                new int[] {1,1,0,0},
                new int[] {1,0,0,1},
                new int[] {0,1,1,1},
                new int[] {1,0,1,0},
            };
            foreach (var item in image2)
            {
                Console.WriteLine(String.Join(",", item));
            }
            Console.WriteLine($"\n--------------------------------------------------------");
            Console.WriteLine("FLIPPED\n");

            var newImage2 = FlipAndInvertImage(image2);
            foreach (var item in newImage2)
            {
                Console.WriteLine(String.Join(",", item));
            }

            //-----------------------------------------------------------------------------------
        }

        public static int[][] FlipAndInvertImage(int[][] image)
        {
            foreach (var item in image)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == 1)
                        item[i] = 0;
                    else if (item[i] == 0)
                        item[i] = 1;
                }

                Array.Reverse(item);
            }

            return image;
        }
    }
}

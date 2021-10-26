using System;
using System.Drawing;
using System.Reflection;
using NUnit.Framework;

namespace SomeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Environment.GetEnvironmentVariable("Build_BuildNumber", EnvironmentVariableTarget.Process);

            foreach (var variable in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process))
            {
                Console.WriteLine(variable);
            }

            Assert.Pass();
        }

        // [Test]
        // public void Test2()
        // {
        //     Assert.Fail();
        // }

        // [Test]
        // public void Test3()
        // {
        //     Console.WriteLine("test1");
        //     Console.WriteLine("test2");
            
        //     Assert.Pass();
        // }

        // [Test]
        // public void Test4()
        // {
        //     Console.WriteLine("test1");
        //     Console.WriteLine("test2");

        //     Assert.Fail();
        // }

       // [Test]
        //public void Test5()
        //{
        //    Console.WriteLine("test1");
        //    Console.WriteLine("test2");

        //    Draw("test5");

        //    Assembly asm = Assembly.GetExecutingAssembly();
        //    string path = System.IO.Path.GetDirectoryName(asm.Location);

        //    TestContext.AddTestAttachment($"{path}//test5.bmp");

        //    Assert.Pass();
        //}

        //[Test]
        //public void Test6()
        //{
        //    Console.WriteLine("test1");
        //    Console.WriteLine("test2");

        //    Draw("test6");

        //    Assembly asm = Assembly.GetExecutingAssembly();
        //    string path = System.IO.Path.GetDirectoryName(asm.Location);

        //    TestContext.AddTestAttachment($"{path}//test6.bmp");

        //    Assert.Fail();
        //}

        //public void Draw(string name)
        //{
        //    var bitmap = new Bitmap(640, 480);

        //    for (var x = 0; x < bitmap.Width; x++)
        //    {
        //        for (var y = 0; y < bitmap.Height; y++)
        //        {
        //            bitmap.SetPixel(x, y, Color.BlueViolet);
        //        }
        //    }

        //    bitmap.Save($"{name}.bmp");
        //}
    }
}
using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;
using System;
using Diary;


namespace Tests
{
    public class CalenderTest
    {
        // Testアトリビュートを付ける
        [Test]
        public void NowTest()
        {
            //現在の時間が入っていること
            Assert.Equals(CalenderModel.GetInstance().Now, DateTime.Now); 
        }
    }
}
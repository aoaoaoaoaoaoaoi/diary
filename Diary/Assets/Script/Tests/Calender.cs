using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;
using System;
using Diary;


namespace Tests
{
    public class CalenderTest
    {
        // Test�A�g���r���[�g��t����
        [Test]
        public void NowTest()
        {
            //���݂̎��Ԃ������Ă��邱��
            Assert.Equals(CalenderModel.GetInstance().Now, DateTime.Now); 
        }
    }
}
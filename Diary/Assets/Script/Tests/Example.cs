using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

namespace Tests
{
    public class Example
    {
        // Test�A�g���r���[�g��t����
        [Test]
        public void ExampleTest()
        {
            // ��������true�������琬��
            Assert.That(1 < 10);
        }

        // UnityTest�A�g���r���[�g��t����
        [UnityTest]
        public IEnumerator ExampleTestEnumerator()
        {
            Assert.That(1 < 10);
            // yield return null��1�t���[���i�߂�
            yield return null;
            Assert.That(2 < 10);
            yield return null;
            Assert.That(3 < 10);
        }
    }
}
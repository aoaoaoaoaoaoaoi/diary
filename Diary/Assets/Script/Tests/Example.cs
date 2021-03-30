using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

namespace Tests
{
    public class Example
    {
        // Testアトリビュートを付ける
        [Test]
        public void ExampleTest()
        {
            // 条件式がtrueだったら成功
            Assert.That(1 < 10);
        }

        // UnityTestアトリビュートを付ける
        [UnityTest]
        public IEnumerator ExampleTestEnumerator()
        {
            Assert.That(1 < 10);
            // yield return nullで1フレーム進める
            yield return null;
            Assert.That(2 < 10);
            yield return null;
            Assert.That(3 < 10);
        }
    }
}
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartialKeyVerification.Hash;
using PartialKeyVerification.Checksum;
using PartialKeyVerification;

namespace PartialKeyTests
{
    /// <summary>
    /// Summary description for VerificationTest
    /// </summary>
    [TestClass]
    public class VerificationTest
    {
        private static readonly Random Random = new Random(0);

        private static readonly IHash[] TestHashes = new IHash[]
            {
                new Fnv1A(), new Jenkins96(), new Crc32(), new GeneralizedCrc(),
                new Jenkins06((uint) Random.Next()), new OneAtATime(), new SuperFast()
            };

        public VerificationTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GenerateListOfKeys()
        {
            foreach (var hash in TestHashes)
            {
                IChecksum16 checksum = new Adler16();
                var baseKeys = new[]
                    {
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next()
                    };
                var gen = new PartialKeyGenerator(checksum, hash, baseKeys) { Spacing = 6 };

                var keys = gen.Generate(100, Random);
                foreach (var key in keys)
                {
                    for (var j = 0; j < baseKeys.Length; j++)
                    {
                        Assert.IsTrue(PartialKeyValidator.ValidateKey(checksum, hash, key.Value, j, baseKeys[j]));
                    }
                }
            }
        }

        [TestMethod]
        public void MultipleHashes()
        {
            IChecksum16 checksum = new Adler16();

            for (uint i = 0; i < 100; i++)
            {
                var baseKeys = new[]
                    {
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next()
                    };

                var gen = new PartialKeyGenerator(checksum, TestHashes, baseKeys) { Spacing = 6 };

                var seed = (uint)Random.Next();
                var key = gen.Generate(seed);

                var hashIndex = 0;
                for (var j = 0; j < baseKeys.Length; j++)
                {
                    Assert.IsTrue(PartialKeyValidator.ValidateKey(checksum, TestHashes[hashIndex++], key, j, baseKeys[j]));
                    hashIndex %= TestHashes.Length;
                }
            }
        }

        [TestMethod]
        public void MultipleHashesWithStringSeed()
        {
            IChecksum16 checksum = new Adler16();

            for (uint i = 0; i < 100; i++)
            {
                var baseKeys = new[]
                    {
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next()
                    };

                var gen = new PartialKeyGenerator(checksum, TestHashes, baseKeys) { Spacing = 6 };

                const string seed = "Bob Smith - bob@smith.com";
                var key = gen.Generate(seed);

                var hashIndex = 0;
                for (var j = 0; j < baseKeys.Length; j++)
                {
                    Assert.IsTrue(PartialKeyValidator.ValidateKey(checksum, TestHashes[hashIndex++], key, j, baseKeys[j],
                                                                  seed));
                    hashIndex %= TestHashes.Length;
                }
            }
        }

        [TestMethod]
        public void RetrieveSerialNumber()
        {
            var generator = new PartialKeyGenerator(new Adler16(), new Jenkins96(), new uint[] { 1, 2, 3, 4 })
            {
                Spacing = 6
            };
            const string stringSeed = "bob@smith.com";
            var key = generator.Generate(stringSeed);
            var serialNumber = PartialKeyValidator.GetSerialNumberFromKey(key);
            Assert.AreEqual(serialNumber, PartialKeyValidator.GetSerialNumberFromSeed(stringSeed));
        }

        [TestMethod]
        public void SingleHash()
        {
            foreach (var hash in TestHashes)
            {
                IChecksum16 checksum = new Adler16();

                for (uint i = 0; i < 100; i++)
                {
                    var baseKeys = new[]
                    {
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next()
                    };
                    var gen = new PartialKeyGenerator(checksum, hash, baseKeys) { Spacing = 6 };

                    var seed = (uint)Random.Next();
                    var key = gen.Generate(seed);

                    for (var j = 0; j < baseKeys.Length; j++)
                    {
                        Assert.IsTrue(PartialKeyValidator.ValidateKey(checksum, hash, key, j, baseKeys[j]));
                    }
                }
            }
        }

        [TestMethod]
        public void SingleHashWithStringSeed()
        {
            foreach (var hash in TestHashes)
            {
                IChecksum16 checksum = new Adler16();

                for (uint i = 0; i < 100; i++)
                {
                    var baseKeys = new[]
                    {
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next(),
                        (uint) Random.Next()
                    };
                    var gen = new PartialKeyGenerator(checksum, hash, baseKeys) { Spacing = 6 };

                    const string seed = "Bob Smith - bob@smith.com";
                    var key = gen.Generate(seed);

                    for (var j = 0; j < baseKeys.Length; j++)
                    {
                        Assert.IsTrue(PartialKeyValidator.ValidateKey(checksum, hash, key, j, baseKeys[j], seed));
                    }
                }
            }
        }
    }
}

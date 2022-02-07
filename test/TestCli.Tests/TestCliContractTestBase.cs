using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace TestCli
{
    public class TestCliContractTestBase : DAppContractTestBase<TestCliContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal TestCliContractContainer.TestCliContractStub GetTestCliContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<TestCliContractContainer.TestCliContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}
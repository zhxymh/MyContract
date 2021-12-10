using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace MyContract
{
    public class MyContractContractTestBase : DAppContractTestBase<MyContractContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal MyContractContractContainer.MyContractContractStub GetMyContractContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<MyContractContractContainer.MyContractContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}
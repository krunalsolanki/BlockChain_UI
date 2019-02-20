using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;


namespace WebApplication1
{
    public partial class VoteService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, VoteDeployment voteDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<VoteDeployment>().SendRequestAndWaitForReceiptAsync(voteDeployment, cancellationTokenSource);
        }
        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, VoteDeployment voteDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<VoteDeployment>().SendRequestAsync(voteDeployment);
        }
        public static async Task<VoteService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, VoteDeployment voteDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, voteDeployment, cancellationTokenSource);
            return new VoteService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public VoteService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> OptionsQueryAsync(OptionsFunction optionsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OptionsFunction, string>(optionsFunction, blockParameter);
        }

        
        public Task<string> OptionsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var optionsFunction = new OptionsFunction();
                optionsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<OptionsFunction, string>(optionsFunction, blockParameter);
        }

        public Task<BigInteger> VotesQueryAsync(VotesFunction votesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<VotesFunction, BigInteger>(votesFunction, blockParameter);
        }

        
        public Task<BigInteger> VotesQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var votesFunction = new VotesFunction();
                votesFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<VotesFunction, BigInteger>(votesFunction, blockParameter);
        }

        public Task<string> VoteRequestAsync(VoteFunction voteFunction)
        {
             return ContractHandler.SendRequestAsync(voteFunction);
        }

        public Task<TransactionReceipt> VoteRequestAndWaitForReceiptAsync(VoteFunction voteFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(voteFunction, cancellationToken);
        }

        public Task<string> VoteRequestAsync(BigInteger option)
        {
            var voteFunction = new VoteFunction();
                voteFunction.Option = option;
            
             return ContractHandler.SendRequestAsync(voteFunction);
        }

        public Task<TransactionReceipt> VoteRequestAndWaitForReceiptAsync(BigInteger option, CancellationTokenSource cancellationToken = null)
        {
            var voteFunction = new VoteFunction();
                voteFunction.Option = option;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(voteFunction, cancellationToken);
        }

        public Task<string> VoteRequestStringAsync(VoteFunction voteFunction)
        {
             return ContractHandler.SendRequestAsync(voteFunction);
        }

        public Task<TransactionReceipt> VoteRequestAndWaitForStringReceiptAsync(VoteFunction voteFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(voteFunction, cancellationToken);
        }

        public Task<string> VoteRequestAsync(string optionName)
        {
            var voteStringFunction = new VoteFunctionStringBase();
                voteStringFunction.OptionName = optionName;
            
             return ContractHandler.SendRequestAsync(voteStringFunction);
        }

        public Task<TransactionReceipt> VoteRequestAndWaitForReceiptAsync(string optionName, CancellationTokenSource cancellationToken = null)
        {
            var voteFunction = new VoteFunctionStringBase();
                voteFunction.OptionName = optionName;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(voteFunction, cancellationToken);
        }

        public Task<List<string>> GetOptionsQueryAsync(GetOptionsFunction getOptionsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOptionsFunction, List<string>>(getOptionsFunction, blockParameter);
        }

        
        public Task<List<string>> GetOptionsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOptionsFunction, List<string>>(null, blockParameter);
        }

        public Task<List<BigInteger>> GetVotesQueryAsync(GetVotesFunction getVotesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetVotesFunction, List<BigInteger>>(getVotesFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> GetVotesQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetVotesFunction, List<BigInteger>>(null, blockParameter);
        }
    }
}

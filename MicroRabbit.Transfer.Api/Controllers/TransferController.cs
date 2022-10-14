using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
         private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public IEnumerable<TransferLog> Get()
        {
            return _transferService.GetTransferLogs();
        }
    }
}

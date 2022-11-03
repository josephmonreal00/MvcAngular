﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace NikeCopy.Services
{
	public class NullMailService : INullMailService
	{
		private readonly ILogger<NullMailService> _logger;
		public NullMailService(ILogger<NullMailService> logger)
		{
			_logger = logger;
		}
		public void SendMessage(string to, string subject, string body)
		{
			// Log the message
			_logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
		}
	}
}

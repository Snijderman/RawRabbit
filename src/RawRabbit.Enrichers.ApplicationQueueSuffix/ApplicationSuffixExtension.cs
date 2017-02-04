﻿using RawRabbit.Pipe;

namespace RawRabbit.Enrichers.ApplicationQueueSuffix
{
	public static class ApplicationSuffixExtension
	{
		private const string ApplicationQueueSuffix = "ApplicationQueueSuffix";

		public static IPipeContext UseApplicationQueueSuffix(this IPipeContext context, bool use = true)
		{
			context.Properties.TryAdd(ApplicationQueueSuffix, use);
			return context;
		}

		public static bool GetApplicationSuffixFlag(this IPipeContext context)
		{
			return context.Get(ApplicationQueueSuffix, true);
		}
	}
}
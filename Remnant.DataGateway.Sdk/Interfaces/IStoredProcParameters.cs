using System;
using System.Collections.Generic;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
	public interface IStoredProcParameters : IExecute, IExecuteList, IExecuteScalar
	{
		/// <summary>
		/// Define input parameter
		/// </summary>
		/// <param name="name">The name of the parameter</param>
		/// <param name="value">The value or bind parameter name</param>
		/// <returns></returns>
		IStoredProcParameters InParameter(string name, object value);

		/// <summary>
		/// Define output parameter
		/// </summary>
		/// <param name="name">The name of the parameter</param>
		/// <param name="type">The data type of the parameter</param>
		/// <param name="size">Optional, the size/length</param>
		/// <returns></returns>
		IStoredProcParameters OutParameter(string name, Type type, int? size = null);

		/// <summary>
		/// Define input/output parameter
		/// </summary>
		/// <param name="name">The name of the parameter</param>
		/// <param name="type">The data type of the parameter</param>
		/// <param name="value">The value or bind parameter name</param>
		/// <param name="size">Optional, the size/length</param>
		/// <returns></returns>
		IStoredProcParameters InOutParameter(string name, Type type, object value, int? size = null);	
	}
}

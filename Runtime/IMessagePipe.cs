using System;
using com.ktgame.unregister;

namespace Message_bus
{
	public interface IMessagePipe
	{
		IUnRegister Register(Action listener);
	}
}

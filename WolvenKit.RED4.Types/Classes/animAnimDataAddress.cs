using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimDataAddress : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("unkIndex")] 
		public CUInt32 UnkIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("fsetInBytes")] 
		public CUInt32 FsetInBytes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("zeInBytes")] 
		public CUInt32 ZeInBytes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimDataAddress()
		{
			UnkIndex = 4294967295;
			FsetInBytes = 4294967295;
			ZeInBytes = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

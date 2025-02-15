using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleAudioPSData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("activeRadioStation")] 
		public CName ActiveRadioStation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("isPlayerVehicleSummoned")] 
		public CBool IsPlayerVehicleSummoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleAudioPSData()
		{
			AcousticIsolationFactor = -340282346638528859811704183484516925440.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

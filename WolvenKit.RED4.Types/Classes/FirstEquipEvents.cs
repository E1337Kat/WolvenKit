using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FirstEquipEvents : EquipmentBaseEvents
	{
		[Ordinal(0)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetPropertyValue<gamestateMachineStateMachineInstanceData>();
			set => SetPropertyValue<gamestateMachineStateMachineInstanceData>(value);
		}

		[Ordinal(1)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<EquipmentInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<EquipmentInitData>>();
			set => SetPropertyValue<CWeakHandle<EquipmentInitData>>(value);
		}

		public FirstEquipEvents()
		{
			StateMachineInstanceData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

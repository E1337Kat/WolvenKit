using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateLinkedClueskRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("linkedCluekData")] public LinkedFocusClueData LinkedCluekData { get; set; }

		public UpdateLinkedClueskRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
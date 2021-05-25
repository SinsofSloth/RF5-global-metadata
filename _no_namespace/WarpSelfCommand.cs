public class WarpSelfCommand : MonsterActionBehaviorCommandBase // TypeDefIndex: 6131
{
	// Fields
	private NavMeshHit NavMeshHit; // 0x28

	// Properties
	public bool IsActiveOwner { get; }
	public NavMeshAgent OwnerNavMesh { get; }

	// Methods

	// RVA: 0x1D06490 Offset: 0x1D06591 VA: 0x1D06490
	public bool get_IsActiveOwner() { }

	// RVA: 0x1D064D0 Offset: 0x1D065D1 VA: 0x1D064D0
	public NavMeshAgent get_OwnerNavMesh() { }

	// RVA: 0x1D06500 Offset: 0x1D06601 VA: 0x1D06500
	public void .ctor(MonsterActionBehaviorController controller, ActionBehaviorCommandInformation info) { }

	// RVA: 0x1D06510 Offset: 0x1D06611 VA: 0x1D06510 Slot: 6
	protected virtual Vector3 OnGetWarpPosition() { }

	// RVA: 0x1D06730 Offset: 0x1D06831 VA: 0x1D06730
	private Vector3 GetWarpPosition() { }

	// RVA: 0x1D068C0 Offset: 0x1D069C1 VA: 0x1D068C0 Slot: 5
	public override void OnExecute() { }
}


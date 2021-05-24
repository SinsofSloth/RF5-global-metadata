public class FishingPoint : MonoBehaviour // TypeDefIndex: 10303
{
	// Fields
	[SerializeField] // RVA: 0x181110 Offset: 0x181211 VA: 0x181110
	public SphereCollider FishSpawnArea; // 0x18
	[SerializeField] // RVA: 0x181120 Offset: 0x181221 VA: 0x181120
	public BoxCollider FishingBox; // 0x20
	[SerializeField] // RVA: 0x181130 Offset: 0x181231 VA: 0x181130
	public int FishSpwanTblNo; // 0x28
	[HideInInspector] // RVA: 0x181140 Offset: 0x181241 VA: 0x181140
	public static int PointFishMax; // 0x0

	// Methods

	// RVA: 0x1D4BAA0 Offset: 0x1D4BBA1 VA: 0x1D4BAA0
	private void OnDestroy() { }

	// RVA: 0x1D4BB10 Offset: 0x1D4BC11 VA: 0x1D4BB10
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1D4BD30 Offset: 0x1D4BE31 VA: 0x1D4BD30
	public void DeleteFish() { }

	// RVA: 0x1D4BE10 Offset: 0x1D4BF11 VA: 0x1D4BE10
	public void .ctor() { }

	// RVA: 0x1D4BE20 Offset: 0x1D4BF21 VA: 0x1D4BE20
	private static void .cctor() { }
}


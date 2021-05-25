public class BeanSowingScore : MonoBehaviour, IPooledObejct // TypeDefIndex: 7356
{
	// Fields
	private readonly Vector3 DISTANCE; // 0x18
	private const float ANIM_TIME = 1;
	private bool firstBoot; // 0x24
	private RectTransform rectTrans; // 0x28
	private Vector3 tarPos; // 0x30
	private float riseSpeed; // 0x3C
	private float riseValue; // 0x40
	[SerializeField] // RVA: 0x165E70 Offset: 0x165F71 VA: 0x165E70
	private FestivalNumScore numScore; // 0x48

	// Methods

	// RVA: 0x20D97C0 Offset: 0x20D98C1 VA: 0x20D97C0 Slot: 4
	public void OnObjectSpawn() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0270 Offset: 0x1A0371 VA: 0x1A0270
	// RVA: 0x20D9A40 Offset: 0x20D9B41 VA: 0x20D9A40
	private IEnumerator Animation() { }

	// RVA: 0x20D9790 Offset: 0x20D9891 VA: 0x20D9790
	public void SetScore(int _score) { }

	// RVA: 0x20D9AF0 Offset: 0x20D9BF1 VA: 0x20D9AF0
	public void .ctor() { }
}


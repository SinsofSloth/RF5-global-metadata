[AddComponentMenu] // RVA: 0x137590 Offset: 0x137691 VA: 0x137590
public class DOTweenComponent : MonoBehaviour, IDOTweenInit // TypeDefIndex: 5065
{
	// Fields
	public int inspectorUpdater; // 0x18
	private float _unscaledTime; // 0x1C
	private float _unscaledDeltaTime; // 0x20
	private bool _paused; // 0x24
	private float _pausedTime; // 0x28
	private bool _duplicateToDestroy; // 0x2C

	// Methods

	// RVA: 0x19855F0 Offset: 0x19856F1 VA: 0x19855F0
	private void Awake() { }

	// RVA: 0x1985EB0 Offset: 0x1985FB1 VA: 0x1985EB0
	private void Start() { }

	// RVA: 0x1985FA0 Offset: 0x19860A1 VA: 0x1985FA0
	private void Update() { }

	// RVA: 0x1986870 Offset: 0x1986971 VA: 0x1986870
	private void LateUpdate() { }

	// RVA: 0x19869D0 Offset: 0x1986AD1 VA: 0x19869D0
	private void FixedUpdate() { }

	// RVA: 0x1986B90 Offset: 0x1986C91 VA: 0x1986B90
	private void OnDrawGizmos() { }

	// RVA: 0x1986D00 Offset: 0x1986E01 VA: 0x1986D00
	private void OnDestroy() { }

	// RVA: 0x1987610 Offset: 0x1987711 VA: 0x1987610
	public void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x1987690 Offset: 0x1987791 VA: 0x1987690 Slot: 4
	public IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x1987800 Offset: 0x1987901 VA: 0x1987800
	internal IEnumerator WaitForCompletion(Tween t) { }

	// RVA: 0x19878B0 Offset: 0x19879B1 VA: 0x19878B0
	internal IEnumerator WaitForRewind(Tween t) { }

	// RVA: 0x1987960 Offset: 0x1987A61 VA: 0x1987960
	internal IEnumerator WaitForKill(Tween t) { }

	// RVA: 0x1987A10 Offset: 0x1987B11 VA: 0x1987A10
	internal IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops) { }

	// RVA: 0x1987AD0 Offset: 0x1987BD1 VA: 0x1987AD0
	internal IEnumerator WaitForPosition(Tween t, float position) { }

	// RVA: 0x1987B90 Offset: 0x1987C91 VA: 0x1987B90
	internal IEnumerator WaitForStart(Tween t) { }

	// RVA: 0x1987C40 Offset: 0x1987D41 VA: 0x1987C40
	internal static void Create() { }

	// RVA: 0x1987D90 Offset: 0x1987E91 VA: 0x1987D90
	internal static void DestroyInstance() { }

	// RVA: 0x1987EC0 Offset: 0x1987FC1 VA: 0x1987EC0
	public void .ctor() { }
}


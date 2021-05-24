public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 3977
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x18BCA20 Offset: 0x18BCB21 VA: 0x18BCA20
	private void Initialize(RectTransform controller) { }

	// RVA: 0x18BCA70 Offset: 0x18BCB71 VA: 0x18BCA70
	private void Clear() { }

	// RVA: 0x18BCAA0 Offset: 0x18BCBA1 VA: 0x18BCAA0
	private static void .cctor() { }

	// RVA: 0x18BCBC0 Offset: 0x18BCCC1 VA: 0x18BCBC0
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x18BCC40 Offset: 0x18BCD41 VA: 0x18BCC40 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x18BCC50 Offset: 0x18BCD51 VA: 0x18BCC50 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x18BCCC0 Offset: 0x18BCDC1 VA: 0x18BCCC0
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x18BCDD0 Offset: 0x18BCED1 VA: 0x18BCDD0
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x18BCEC0 Offset: 0x18BCFC1 VA: 0x18BCEC0 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18BD4F0 Offset: 0x18BD5F1 VA: 0x18BD4F0
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x18BD210 Offset: 0x18BD311 VA: 0x18BD210
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x18BB050 Offset: 0x18BB151 VA: 0x18BB050
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x18BD8B0 Offset: 0x18BD9B1 VA: 0x18BD8B0
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x18BDA90 Offset: 0x18BDB91 VA: 0x18BDA90
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x18BDC10 Offset: 0x18BDD11 VA: 0x18BDC10 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x18BDCA0 Offset: 0x18BDDA1 VA: 0x18BDCA0 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x18BDCB0 Offset: 0x18BDDB1 VA: 0x18BDCB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18BDCC0 Offset: 0x18BDDC1 VA: 0x18BDCC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18BDD20 Offset: 0x18BDE21 VA: 0x18BDD20 Slot: 3
	public override string ToString() { }

	// RVA: 0x18BDD80 Offset: 0x18BDE81 VA: 0x18BDD80
	public void .ctor() { }
}


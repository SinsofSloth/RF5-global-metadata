public class GandageHandController.MaterialFadeController // TypeDefIndex: 7855
{
	// Fields
	private Material _Material; // 0x10
	private float Timer; // 0x18
	private float Duration; // 0x1C
	private float FadeStartParam; // 0x20
	private GandageHandController.MaterialFadeController.FadeType _FadeType; // 0x24

	// Methods

	// RVA: 0x1E38730 Offset: 0x1E38831 VA: 0x1E38730
	public void .ctor(Material material) { }

	// RVA: 0x1E38EB0 Offset: 0x1E38FB1 VA: 0x1E38EB0
	protected void SetEnableDither(Material material, bool enable) { }

	// RVA: 0x1E38FA0 Offset: 0x1E390A1 VA: 0x1E38FA0
	protected void SetEnableDitherAlpha(Material material, bool enable) { }

	// RVA: 0x1E38B00 Offset: 0x1E38C01 VA: 0x1E38B00
	public void OnStartFade(GandageHandController.MaterialFadeController.FadeType fadeType, float duration, bool isBetween) { }

	// RVA: 0x1E387D0 Offset: 0x1E388D1 VA: 0x1E387D0
	public void OnUpdateFadeing() { }

	// RVA: 0x1E39090 Offset: 0x1E39191 VA: 0x1E39090
	private void EndFade() { }
}


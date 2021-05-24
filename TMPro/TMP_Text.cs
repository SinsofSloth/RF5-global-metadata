public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 5864
{
	// Fields
	[SerializeField] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	[TextAreaAttribute] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	protected string m_text; // 0xC0
	[SerializeField] // RVA: 0x13FE90 Offset: 0x13FF91 VA: 0x13FE90
	protected ITextPreprocessor m_TextPreprocessor; // 0xC8
	[SerializeField] // RVA: 0x13FEA0 Offset: 0x13FFA1 VA: 0x13FEA0
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x13FEB0 Offset: 0x13FFB1 VA: 0x13FEB0
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x13FEC0 Offset: 0x13FFC1 VA: 0x13FEC0
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x168
	[SerializeField] // RVA: 0x13FED0 Offset: 0x13FFD1 VA: 0x13FED0
	protected Material[] m_fontSharedMaterials; // 0x170
	[SerializeField] // RVA: 0x13FEE0 Offset: 0x13FFE1 VA: 0x13FEE0
	protected Material m_fontMaterial; // 0x178
	[SerializeField] // RVA: 0x13FEF0 Offset: 0x13FFF1 VA: 0x13FEF0
	protected Material[] m_fontMaterials; // 0x180
	protected bool m_isMaterialDirty; // 0x188
	[SerializeField] // RVA: 0x13FF00 Offset: 0x140001 VA: 0x13FF00
	protected Color32 m_fontColor32; // 0x18C
	[SerializeField] // RVA: 0x13FF10 Offset: 0x140011 VA: 0x13FF10
	protected Color m_fontColor; // 0x190
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x1A0
	protected Color32 m_strikethroughColor; // 0x1A4
	[SerializeField] // RVA: 0x13FF20 Offset: 0x140021 VA: 0x13FF20
	protected bool m_enableVertexGradient; // 0x1A8
	[SerializeField] // RVA: 0x13FF30 Offset: 0x140031 VA: 0x13FF30
	protected ColorMode m_colorMode; // 0x1AC
	[SerializeField] // RVA: 0x13FF40 Offset: 0x140041 VA: 0x13FF40
	protected VertexGradient m_fontColorGradient; // 0x1B0
	[SerializeField] // RVA: 0x13FF50 Offset: 0x140051 VA: 0x13FF50
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x13FF60 Offset: 0x140061 VA: 0x13FF60
	protected TMP_SpriteAsset m_spriteAsset; // 0x1F8
	[SerializeField] // RVA: 0x13FF70 Offset: 0x140071 VA: 0x13FF70
	protected bool m_tintAllSprites; // 0x200
	protected bool m_tintSprite; // 0x201
	protected Color32 m_spriteColor; // 0x204
	[SerializeField] // RVA: 0x13FF80 Offset: 0x140081 VA: 0x13FF80
	protected TMP_StyleSheet m_StyleSheet; // 0x208
	internal TMP_Style m_TextStyle; // 0x210
	[SerializeField] // RVA: 0x13FF90 Offset: 0x140091 VA: 0x13FF90
	protected int m_TextStyleHashCode; // 0x218
	[SerializeField] // RVA: 0x13FFA0 Offset: 0x1400A1 VA: 0x13FFA0
	protected bool m_overrideHtmlColors; // 0x21C
	[SerializeField] // RVA: 0x13FFB0 Offset: 0x1400B1 VA: 0x13FFB0
	protected Color32 m_faceColor; // 0x220
	protected Color32 m_outlineColor; // 0x224
	protected float m_outlineWidth; // 0x228
	[SerializeField] // RVA: 0x13FFC0 Offset: 0x1400C1 VA: 0x13FFC0
	protected float m_fontSize; // 0x22C
	protected float m_currentFontSize; // 0x230
	[SerializeField] // RVA: 0x13FFD0 Offset: 0x1400D1 VA: 0x13FFD0
	protected float m_fontSizeBase; // 0x234
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x238
	[SerializeField] // RVA: 0x13FFE0 Offset: 0x1400E1 VA: 0x13FFE0
	protected FontWeight m_fontWeight; // 0x258
	protected FontWeight m_FontWeightInternal; // 0x25C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x260
	[SerializeField] // RVA: 0x13FFF0 Offset: 0x1400F1 VA: 0x13FFF0
	protected bool m_enableAutoSizing; // 0x280
	protected float m_maxFontSize; // 0x284
	protected float m_minFontSize; // 0x288
	protected int m_AutoSizeIterationCount; // 0x28C
	protected int m_AutoSizeMaxIterationCount; // 0x290
	protected bool m_IsAutoSizePointSizeSet; // 0x294
	[SerializeField] // RVA: 0x140000 Offset: 0x140101 VA: 0x140000
	protected float m_fontSizeMin; // 0x298
	[SerializeField] // RVA: 0x140010 Offset: 0x140111 VA: 0x140010
	protected float m_fontSizeMax; // 0x29C
	[SerializeField] // RVA: 0x140020 Offset: 0x140121 VA: 0x140020
	protected FontStyles m_fontStyle; // 0x2A0
	protected FontStyles m_FontStyleInternal; // 0x2A4
	protected TMP_FontStyleStack m_fontStyleStack; // 0x2A8
	protected bool m_isUsingBold; // 0x2B2
	[SerializeField] // RVA: 0x140030 Offset: 0x140131 VA: 0x140030
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x2B4
	[SerializeField] // RVA: 0x140040 Offset: 0x140141 VA: 0x140040
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x2B8
	[SerializeField] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	[FormerlySerializedAsAttribute] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	protected TextAlignmentOptions m_textAlignment; // 0x2BC
	protected HorizontalAlignmentOptions m_lineJustification; // 0x2C0
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2C8
	protected Vector3[] m_textContainerLocalCorners; // 0x2E8
	[SerializeField] // RVA: 0x1400A0 Offset: 0x1401A1 VA: 0x1400A0
	protected float m_characterSpacing; // 0x2F0
	protected float m_cSpacing; // 0x2F4
	protected float m_monoSpacing; // 0x2F8
	[SerializeField] // RVA: 0x1400B0 Offset: 0x1401B1 VA: 0x1400B0
	protected float m_wordSpacing; // 0x2FC
	[SerializeField] // RVA: 0x1400C0 Offset: 0x1401C1 VA: 0x1400C0
	protected float m_lineSpacing; // 0x300
	protected float m_lineSpacingDelta; // 0x304
	protected float m_lineHeight; // 0x308
	protected bool m_IsDrivenLineSpacing; // 0x30C
	[SerializeField] // RVA: 0x1400D0 Offset: 0x1401D1 VA: 0x1400D0
	protected float m_lineSpacingMax; // 0x310
	[SerializeField] // RVA: 0x1400E0 Offset: 0x1401E1 VA: 0x1400E0
	protected float m_paragraphSpacing; // 0x314
	[SerializeField] // RVA: 0x1400F0 Offset: 0x1401F1 VA: 0x1400F0
	protected float m_charWidthMaxAdj; // 0x318
	protected float m_charWidthAdjDelta; // 0x31C
	[SerializeField] // RVA: 0x140100 Offset: 0x140201 VA: 0x140100
	protected bool m_enableWordWrapping; // 0x320
	protected bool m_isCharacterWrappingEnabled; // 0x321
	protected bool m_isNonBreakingSpace; // 0x322
	protected bool m_isIgnoringAlignment; // 0x323
	[SerializeField] // RVA: 0x140110 Offset: 0x140211 VA: 0x140110
	protected float m_wordWrappingRatios; // 0x324
	[SerializeField] // RVA: 0x140120 Offset: 0x140221 VA: 0x140120
	protected TextOverflowModes m_overflowMode; // 0x328
	protected int m_firstOverflowCharacterIndex; // 0x32C
	[SerializeField] // RVA: 0x140130 Offset: 0x140231 VA: 0x140130
	protected TMP_Text m_linkedTextComponent; // 0x330
	[SerializeField] // RVA: 0x140140 Offset: 0x140241 VA: 0x140140
	internal TMP_Text parentLinkedComponent; // 0x338
	protected bool m_isTextTruncated; // 0x340
	[SerializeField] // RVA: 0x140150 Offset: 0x140251 VA: 0x140150
	protected bool m_enableKerning; // 0x341
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x344
	[SerializeField] // RVA: 0x140160 Offset: 0x140261 VA: 0x140160
	protected bool m_enableExtraPadding; // 0x348
	[SerializeField] // RVA: 0x140170 Offset: 0x140271 VA: 0x140170
	protected bool checkPaddingRequired; // 0x349
	[SerializeField] // RVA: 0x140180 Offset: 0x140281 VA: 0x140180
	protected bool m_isRichText; // 0x34A
	[SerializeField] // RVA: 0x140190 Offset: 0x140291 VA: 0x140190
	protected bool m_parseCtrlCharacters; // 0x34B
	protected bool m_isOverlay; // 0x34C
	[SerializeField] // RVA: 0x1401A0 Offset: 0x1402A1 VA: 0x1401A0
	protected bool m_isOrthographic; // 0x34D
	[SerializeField] // RVA: 0x1401B0 Offset: 0x1402B1 VA: 0x1401B0
	protected bool m_isCullingEnabled; // 0x34E
	protected bool m_isMaskingEnabled; // 0x34F
	protected bool isMaskUpdateRequired; // 0x350
	protected bool m_ignoreCulling; // 0x351
	[SerializeField] // RVA: 0x1401C0 Offset: 0x1402C1 VA: 0x1401C0
	protected TextureMappingOptions m_horizontalMapping; // 0x354
	[SerializeField] // RVA: 0x1401D0 Offset: 0x1402D1 VA: 0x1401D0
	protected TextureMappingOptions m_verticalMapping; // 0x358
	[SerializeField] // RVA: 0x1401E0 Offset: 0x1402E1 VA: 0x1401E0
	protected float m_uvLineOffset; // 0x35C
	protected TextRenderFlags m_renderMode; // 0x360
	[SerializeField] // RVA: 0x1401F0 Offset: 0x1402F1 VA: 0x1401F0
	protected VertexSortingOrder m_geometrySortingOrder; // 0x364
	[SerializeField] // RVA: 0x140200 Offset: 0x140301 VA: 0x140200
	protected bool m_IsTextObjectScaleStatic; // 0x368
	[SerializeField] // RVA: 0x140210 Offset: 0x140311 VA: 0x140210
	protected bool m_VertexBufferAutoSizeReduction; // 0x369
	protected int m_firstVisibleCharacter; // 0x36C
	protected int m_maxVisibleCharacters; // 0x370
	protected int m_maxVisibleWords; // 0x374
	protected int m_maxVisibleLines; // 0x378
	[SerializeField] // RVA: 0x140220 Offset: 0x140321 VA: 0x140220
	protected bool m_useMaxVisibleDescender; // 0x37C
	[SerializeField] // RVA: 0x140230 Offset: 0x140331 VA: 0x140230
	protected int m_pageToDisplay; // 0x380
	protected bool m_isNewPage; // 0x384
	[SerializeField] // RVA: 0x140240 Offset: 0x140341 VA: 0x140240
	protected Vector4 m_margin; // 0x388
	protected float m_marginLeft; // 0x398
	protected float m_marginRight; // 0x39C
	protected float m_marginWidth; // 0x3A0
	protected float m_marginHeight; // 0x3A4
	protected float m_width; // 0x3A8
	protected TMP_TextInfo m_textInfo; // 0x3B0
	protected bool m_havePropertiesChanged; // 0x3B8
	[SerializeField] // RVA: 0x140250 Offset: 0x140351 VA: 0x140250
	protected bool m_isUsingLegacyAnimationComponent; // 0x3B9
	protected Transform m_transform; // 0x3C0
	protected RectTransform m_rectTransform; // 0x3C8
	protected Vector2 m_PreviousRectTransformSize; // 0x3D0
	protected Vector2 m_PreviousPivotPosition; // 0x3D8
	[CompilerGeneratedAttribute] // RVA: 0x140260 Offset: 0x140361 VA: 0x140260
	private bool <autoSizeTextContainer>k__BackingField; // 0x3E0
	protected bool m_autoSizeTextContainer; // 0x3E1
	protected Mesh m_mesh; // 0x3E8
	[SerializeField] // RVA: 0x140270 Offset: 0x140371 VA: 0x140270
	protected bool m_isVolumetricText; // 0x3F0
	[CompilerGeneratedAttribute] // RVA: 0x140280 Offset: 0x140381 VA: 0x140280
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x140290 Offset: 0x140391 VA: 0x140290
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1402A0 Offset: 0x1403A1 VA: 0x1402A0
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3F8
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x400
	protected float m_flexibleHeight; // 0x408
	protected float m_flexibleWidth; // 0x40C
	protected float m_minWidth; // 0x410
	protected float m_minHeight; // 0x414
	protected float m_maxWidth; // 0x418
	protected float m_maxHeight; // 0x41C
	protected LayoutElement m_LayoutElement; // 0x420
	protected float m_preferredWidth; // 0x428
	protected float m_renderedWidth; // 0x42C
	protected bool m_isPreferredWidthDirty; // 0x430
	protected float m_preferredHeight; // 0x434
	protected float m_renderedHeight; // 0x438
	protected bool m_isPreferredHeightDirty; // 0x43C
	protected bool m_isCalculatingPreferredValues; // 0x43D
	protected int m_layoutPriority; // 0x440
	protected bool m_isLayoutDirty; // 0x444
	protected bool m_isAwake; // 0x445
	internal bool m_isWaitingOnResourceLoad; // 0x446
	internal bool m_isInputParsingRequired; // 0x447
	internal TMP_Text.TextInputSources m_inputSource; // 0x448
	protected float m_fontScale; // 0x44C
	protected float m_fontScaleMultiplier; // 0x450
	protected char[] m_htmlTag; // 0x458
	protected RichTextTagAttribute[] m_xmlAttribute; // 0x460
	protected float[] m_attributeParameterValues; // 0x468
	protected float tag_LineIndent; // 0x470
	protected float tag_Indent; // 0x474
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x478
	protected bool tag_NoParsing; // 0x498
	protected bool m_isParsingText; // 0x499
	protected Matrix4x4 m_FXMatrix; // 0x49C
	protected bool m_isFXMatrixSet; // 0x4DC
	protected TMP_Text.UnicodeChar[] m_InternalParsingBuffer; // 0x4E0
	protected int m_InternalParsingBufferSize; // 0x4E8
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x4F0
	protected char[] m_input_CharArray; // 0x4F8
	private int m_charArray_Length; // 0x500
	protected int m_totalCharacterCount; // 0x504
	protected WordWrapState m_SavedWordWrapState; // 0x508
	protected WordWrapState m_SavedLineState; // 0x880
	protected WordWrapState m_SavedEllipsisState; // 0xBF8
	protected WordWrapState m_SavedLastValidState; // 0xF70
	protected WordWrapState m_SavedSoftLineBreakState; // 0x12E8
	internal TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1660
	protected int m_characterCount; // 0x19F8
	protected int m_firstCharacterOfLine; // 0x19FC
	protected int m_firstVisibleCharacterOfLine; // 0x1A00
	protected int m_lastCharacterOfLine; // 0x1A04
	protected int m_lastVisibleCharacterOfLine; // 0x1A08
	protected int m_lineNumber; // 0x1A0C
	protected int m_lineVisibleCharacterCount; // 0x1A10
	protected int m_pageNumber; // 0x1A14
	protected float m_PageAscender; // 0x1A18
	protected float m_maxTextAscender; // 0x1A1C
	protected float m_maxCapHeight; // 0x1A20
	protected float m_ElementAscender; // 0x1A24
	protected float m_ElementDescender; // 0x1A28
	protected float m_maxLineAscender; // 0x1A2C
	protected float m_maxLineDescender; // 0x1A30
	protected float m_startOfLineAscender; // 0x1A34
	protected float m_startOfLineDescender; // 0x1A38
	protected float m_lineOffset; // 0x1A3C
	protected Extents m_meshExtents; // 0x1A40
	protected Color32 m_htmlColor; // 0x1A50
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x1A58
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x1A78
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x1A98
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x1AB8
	protected TMP_ColorGradient m_colorGradientPreset; // 0x1AE8
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x1AF0
	protected bool m_colorGradientPresetIsTinted; // 0x1B18
	protected float m_tabSpacing; // 0x1B1C
	protected float m_spacing; // 0x1B20
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x1B28
	protected int m_TextStyleStackDepth; // 0x1B30
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x1B38
	protected int m_ItalicAngle; // 0x1B58
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x1B60
	protected float m_padding; // 0x1B80
	protected float m_baselineOffset; // 0x1B84
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x1B88
	protected float m_xAdvance; // 0x1BA8
	protected TMP_TextElementType m_textElementType; // 0x1BAC
	protected TMP_TextElement m_cached_TextElement; // 0x1BB0
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x1BB8
	protected TMP_Text.SpecialCharacter m_Underline; // 0x1BD8
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x1BF8
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x1C00
	protected int m_spriteCount; // 0x1C08
	protected int m_spriteIndex; // 0x1C0C
	protected int m_spriteAnimationID; // 0x1C10
	protected bool m_ignoreActiveState; // 0x1C14
	private readonly Decimal[] k_Power; // 0x1C18
	protected static Vector2 k_LargePositiveVector2; // 0x18
	protected static Vector2 k_LargeNegativeVector2; // 0x20
	protected static float k_LargePositiveFloat; // 0x28
	protected static float k_LargeNegativeFloat; // 0x2C
	protected static int k_LargePositiveInt; // 0x30
	protected static int k_LargeNegativeInt; // 0x34

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public float fontScale { get; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x14CDCA0 Offset: 0x14CDDA1 VA: 0x14CDCA0 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x14CDCB0 Offset: 0x14CDDB1 VA: 0x14CDCB0 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x14CDD60 Offset: 0x14CDE61 VA: 0x14CDD60
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x14CDD70 Offset: 0x14CDE71 VA: 0x14CDD70
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x14CDD80 Offset: 0x14CDE81 VA: 0x14CDD80
	public bool get_isRightToLeftText() { }

	// RVA: 0x14CDD90 Offset: 0x14CDE91 VA: 0x14CDD90
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x14CDE00 Offset: 0x14CDF01 VA: 0x14CDE00
	public TMP_FontAsset get_font() { }

	// RVA: 0x14CDE10 Offset: 0x14CDF11 VA: 0x14CDE10
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x14CDF00 Offset: 0x14CE001 VA: 0x14CDF00 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x14CDF10 Offset: 0x14CE011 VA: 0x14CDF10 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x14CDFF0 Offset: 0x14CE0F1 VA: 0x14CDFF0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x14CE000 Offset: 0x14CE101 VA: 0x14CE000 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x14CE060 Offset: 0x14CE161 VA: 0x14CE060
	public Material get_fontMaterial() { }

	// RVA: 0x14CE080 Offset: 0x14CE181 VA: 0x14CE080
	public void set_fontMaterial(Material value) { }

	// RVA: 0x14CE1A0 Offset: 0x14CE2A1 VA: 0x14CE1A0 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x14CE1C0 Offset: 0x14CE2C1 VA: 0x14CE1C0 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x14CE220 Offset: 0x14CE321 VA: 0x14CE220 Slot: 22
	public override Color get_color() { }

	// RVA: 0x14CE240 Offset: 0x14CE341 VA: 0x14CE240 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x14CE2F0 Offset: 0x14CE3F1 VA: 0x14CE2F0
	public float get_alpha() { }

	// RVA: 0x14CE300 Offset: 0x14CE401 VA: 0x14CE300
	public void set_alpha(float value) { }

	// RVA: 0x14CE330 Offset: 0x14CE431 VA: 0x14CE330
	public bool get_enableVertexGradient() { }

	// RVA: 0x14CE340 Offset: 0x14CE441 VA: 0x14CE340
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x14CE380 Offset: 0x14CE481 VA: 0x14CE380
	public VertexGradient get_colorGradient() { }

	// RVA: 0x14CE3B0 Offset: 0x14CE4B1 VA: 0x14CE3B0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x14CE3F0 Offset: 0x14CE4F1 VA: 0x14CE3F0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x14CE400 Offset: 0x14CE501 VA: 0x14CE400
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x14CE440 Offset: 0x14CE541 VA: 0x14CE440
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x14CE450 Offset: 0x14CE551 VA: 0x14CE450
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x14CE4B0 Offset: 0x14CE5B1 VA: 0x14CE4B0
	public bool get_tintAllSprites() { }

	// RVA: 0x14CE4C0 Offset: 0x14CE5C1 VA: 0x14CE4C0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x14CE500 Offset: 0x14CE601 VA: 0x14CE500
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x14CE510 Offset: 0x14CE611 VA: 0x14CE510
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x14CE570 Offset: 0x14CE671 VA: 0x14CE570
	public TMP_Style get_textStyle() { }

	// RVA: 0x14CE830 Offset: 0x14CE931 VA: 0x14CE830
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x14CE8A0 Offset: 0x14CE9A1 VA: 0x14CE8A0
	public bool get_overrideColorTags() { }

	// RVA: 0x14CE8B0 Offset: 0x14CE9B1 VA: 0x14CE8B0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x14CE8F0 Offset: 0x14CE9F1 VA: 0x14CE8F0
	public Color32 get_faceColor() { }

	// RVA: 0x14CE9E0 Offset: 0x14CEAE1 VA: 0x14CE9E0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x14CEA80 Offset: 0x14CEB81 VA: 0x14CEA80
	public Color32 get_outlineColor() { }

	// RVA: 0x14CEB70 Offset: 0x14CEC71 VA: 0x14CEB70
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x14CEC00 Offset: 0x14CED01 VA: 0x14CEC00
	public float get_outlineWidth() { }

	// RVA: 0x14CECE0 Offset: 0x14CEDE1 VA: 0x14CECE0
	public void set_outlineWidth(float value) { }

	// RVA: 0x14CED60 Offset: 0x14CEE61 VA: 0x14CED60
	public float get_fontSize() { }

	// RVA: 0x14CED70 Offset: 0x14CEE71 VA: 0x14CED70
	public void set_fontSize(float value) { }

	// RVA: 0x14CEDE0 Offset: 0x14CEEE1 VA: 0x14CEDE0
	public float get_fontScale() { }

	// RVA: 0x14CEDF0 Offset: 0x14CEEF1 VA: 0x14CEDF0
	public FontWeight get_fontWeight() { }

	// RVA: 0x14CEE00 Offset: 0x14CEF01 VA: 0x14CEE00
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x14CEE60 Offset: 0x14CEF61 VA: 0x14CEE60
	public float get_pixelsPerUnit() { }

	// RVA: 0x14CF010 Offset: 0x14CF111 VA: 0x14CF010
	public bool get_enableAutoSizing() { }

	// RVA: 0x14CF020 Offset: 0x14CF121 VA: 0x14CF020
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x14CF080 Offset: 0x14CF181 VA: 0x14CF080
	public float get_fontSizeMin() { }

	// RVA: 0x14CF090 Offset: 0x14CF191 VA: 0x14CF090
	public void set_fontSizeMin(float value) { }

	// RVA: 0x14CF0E0 Offset: 0x14CF1E1 VA: 0x14CF0E0
	public float get_fontSizeMax() { }

	// RVA: 0x14CF0F0 Offset: 0x14CF1F1 VA: 0x14CF0F0
	public void set_fontSizeMax(float value) { }

	// RVA: 0x14CF140 Offset: 0x14CF241 VA: 0x14CF140
	public FontStyles get_fontStyle() { }

	// RVA: 0x14CF150 Offset: 0x14CF251 VA: 0x14CF150
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x14CF1B0 Offset: 0x14CF2B1 VA: 0x14CF1B0
	public bool get_isUsingBold() { }

	// RVA: 0x14CF1C0 Offset: 0x14CF2C1 VA: 0x14CF1C0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x14CF1D0 Offset: 0x14CF2D1 VA: 0x14CF1D0
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x14CF200 Offset: 0x14CF301 VA: 0x14CF200
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x14CF210 Offset: 0x14CF311 VA: 0x14CF210
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x14CF240 Offset: 0x14CF341 VA: 0x14CF240
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x14CF250 Offset: 0x14CF351 VA: 0x14CF250
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x14CF2A0 Offset: 0x14CF3A1 VA: 0x14CF2A0
	public float get_characterSpacing() { }

	// RVA: 0x14CF2B0 Offset: 0x14CF3B1 VA: 0x14CF2B0
	public void set_characterSpacing(float value) { }

	// RVA: 0x14CF310 Offset: 0x14CF411 VA: 0x14CF310
	public float get_wordSpacing() { }

	// RVA: 0x14CF320 Offset: 0x14CF421 VA: 0x14CF320
	public void set_wordSpacing(float value) { }

	// RVA: 0x14CF380 Offset: 0x14CF481 VA: 0x14CF380
	public float get_lineSpacing() { }

	// RVA: 0x14CF390 Offset: 0x14CF491 VA: 0x14CF390
	public void set_lineSpacing(float value) { }

	// RVA: 0x14CF3F0 Offset: 0x14CF4F1 VA: 0x14CF3F0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x14CF400 Offset: 0x14CF501 VA: 0x14CF400
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x14CF460 Offset: 0x14CF561 VA: 0x14CF460
	public float get_paragraphSpacing() { }

	// RVA: 0x14CF470 Offset: 0x14CF571 VA: 0x14CF470
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x14CF4D0 Offset: 0x14CF5D1 VA: 0x14CF4D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x14CF4E0 Offset: 0x14CF5E1 VA: 0x14CF4E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x14CF540 Offset: 0x14CF641 VA: 0x14CF540
	public bool get_enableWordWrapping() { }

	// RVA: 0x14CF550 Offset: 0x14CF651 VA: 0x14CF550
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x14CF5C0 Offset: 0x14CF6C1 VA: 0x14CF5C0
	public float get_wordWrappingRatios() { }

	// RVA: 0x14CF5D0 Offset: 0x14CF6D1 VA: 0x14CF5D0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x14CF630 Offset: 0x14CF731 VA: 0x14CF630
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x14CF640 Offset: 0x14CF741 VA: 0x14CF640
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x14CF6A0 Offset: 0x14CF7A1 VA: 0x14CF6A0
	public bool get_isTextOverflowing() { }

	// RVA: 0x14CF6B0 Offset: 0x14CF7B1 VA: 0x14CF6B0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x14CF6C0 Offset: 0x14CF7C1 VA: 0x14CF6C0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x14CF6D0 Offset: 0x14CF7D1 VA: 0x14CF6D0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x14CFA50 Offset: 0x14CFB51 VA: 0x14CFA50
	public bool get_isTextTruncated() { }

	// RVA: 0x14CFA60 Offset: 0x14CFB61 VA: 0x14CFA60
	public bool get_enableKerning() { }

	// RVA: 0x14CFA70 Offset: 0x14CFB71 VA: 0x14CFA70
	public void set_enableKerning(bool value) { }

	// RVA: 0x14CFAE0 Offset: 0x14CFBE1 VA: 0x14CFAE0
	public bool get_extraPadding() { }

	// RVA: 0x14CFAF0 Offset: 0x14CFBF1 VA: 0x14CFAF0
	public void set_extraPadding(bool value) { }

	// RVA: 0x14CFB60 Offset: 0x14CFC61 VA: 0x14CFB60
	public bool get_richText() { }

	// RVA: 0x14CFB70 Offset: 0x14CFC71 VA: 0x14CFB70
	public void set_richText(bool value) { }

	// RVA: 0x14CFBE0 Offset: 0x14CFCE1 VA: 0x14CFBE0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x14CFBF0 Offset: 0x14CFCF1 VA: 0x14CFBF0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x14CFC60 Offset: 0x14CFD61 VA: 0x14CFC60
	public bool get_isOverlay() { }

	// RVA: 0x14CFC70 Offset: 0x14CFD71 VA: 0x14CFC70
	public void set_isOverlay(bool value) { }

	// RVA: 0x14CFCE0 Offset: 0x14CFDE1 VA: 0x14CFCE0
	public bool get_isOrthographic() { }

	// RVA: 0x14CFCF0 Offset: 0x14CFDF1 VA: 0x14CFCF0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x14CFD30 Offset: 0x14CFE31 VA: 0x14CFD30
	public bool get_enableCulling() { }

	// RVA: 0x14CFD40 Offset: 0x14CFE41 VA: 0x14CFD40
	public void set_enableCulling(bool value) { }

	// RVA: 0x14CFD90 Offset: 0x14CFE91 VA: 0x14CFD90
	public bool get_ignoreVisibility() { }

	// RVA: 0x14CFDA0 Offset: 0x14CFEA1 VA: 0x14CFDA0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x14CFDD0 Offset: 0x14CFED1 VA: 0x14CFDD0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x14CFDE0 Offset: 0x14CFEE1 VA: 0x14CFDE0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE10 Offset: 0x14CFF11 VA: 0x14CFE10
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x14CFE20 Offset: 0x14CFF21 VA: 0x14CFE20
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE50 Offset: 0x14CFF51 VA: 0x14CFE50
	public float get_mappingUvLineOffset() { }

	// RVA: 0x14CFE60 Offset: 0x14CFF61 VA: 0x14CFE60
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x14CFE90 Offset: 0x14CFF91 VA: 0x14CFE90
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x14CFEA0 Offset: 0x14CFFA1 VA: 0x14CFEA0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x14CFEC0 Offset: 0x14CFFC1 VA: 0x14CFEC0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x14CFED0 Offset: 0x14CFFD1 VA: 0x14CFED0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x14CFEF0 Offset: 0x14CFFF1 VA: 0x14CFEF0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x14CFF00 Offset: 0x14D0001 VA: 0x14CFF00
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x14CFF20 Offset: 0x14D0021 VA: 0x14CFF20
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x14CFF30 Offset: 0x14D0031 VA: 0x14CFF30
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x14CFF50 Offset: 0x14D0051 VA: 0x14CFF50
	public int get_firstVisibleCharacter() { }

	// RVA: 0x14CFF60 Offset: 0x14D0061 VA: 0x14CFF60
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x14CFF90 Offset: 0x14D0091 VA: 0x14CFF90
	public int get_maxVisibleCharacters() { }

	// RVA: 0x14CFFA0 Offset: 0x14D00A1 VA: 0x14CFFA0
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x14CFFD0 Offset: 0x14D00D1 VA: 0x14CFFD0
	public int get_maxVisibleWords() { }

	// RVA: 0x14CFFE0 Offset: 0x14D00E1 VA: 0x14CFFE0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x14D0010 Offset: 0x14D0111 VA: 0x14D0010
	public int get_maxVisibleLines() { }

	// RVA: 0x14D0020 Offset: 0x14D0121 VA: 0x14D0020
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x14D0050 Offset: 0x14D0151 VA: 0x14D0050
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x14D0060 Offset: 0x14D0161 VA: 0x14D0060
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x14D00A0 Offset: 0x14D01A1 VA: 0x14D00A0
	public int get_pageToDisplay() { }

	// RVA: 0x14D00B0 Offset: 0x14D01B1 VA: 0x14D00B0
	public void set_pageToDisplay(int value) { }

	// RVA: 0x14D00E0 Offset: 0x14D01E1 VA: 0x14D00E0 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x14D0100 Offset: 0x14D0201 VA: 0x14D0100 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x14D0230 Offset: 0x14D0331 VA: 0x14D0230
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x14D0240 Offset: 0x14D0341 VA: 0x14D0240
	public bool get_havePropertiesChanged() { }

	// RVA: 0x14CBB20 Offset: 0x14CBC21 VA: 0x14CBB20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x14D0250 Offset: 0x14D0351 VA: 0x14D0250
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x14D0260 Offset: 0x14D0361 VA: 0x14D0260
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x14CCE50 Offset: 0x14CCF51 VA: 0x14CCE50
	public Transform get_transform() { }

	// RVA: 0x14CCF00 Offset: 0x14CD001 VA: 0x14CCF00
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x140690 Offset: 0x140791 VA: 0x140690
	// RVA: 0x14D0270 Offset: 0x14D0371 VA: 0x14D0270 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406A0 Offset: 0x1407A1 VA: 0x1406A0
	// RVA: 0x14D0280 Offset: 0x14D0381 VA: 0x14D0280 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x14D0290 Offset: 0x14D0391 VA: 0x14D0290 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x14D02A0 Offset: 0x14D03A1 VA: 0x14D02A0
	public bool get_isVolumetricText() { }

	// RVA: 0x14D02B0 Offset: 0x14D03B1 VA: 0x14D02B0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x14D0340 Offset: 0x14D0441 VA: 0x14D0340
	public Bounds get_bounds() { }

	// RVA: 0x14D03F0 Offset: 0x14D04F1 VA: 0x14D03F0
	public Bounds get_textBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406B0 Offset: 0x1407B1 VA: 0x1406B0
	// RVA: 0x14D06D0 Offset: 0x14D07D1 VA: 0x14D06D0
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406C0 Offset: 0x1407C1 VA: 0x1406C0
	// RVA: 0x14D07C0 Offset: 0x14D08C1 VA: 0x14D07C0
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406D0 Offset: 0x1407D1 VA: 0x1406D0
	// RVA: 0x14D08B0 Offset: 0x14D09B1 VA: 0x14D08B0
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406E0 Offset: 0x1407E1 VA: 0x1406E0
	// RVA: 0x14D09A0 Offset: 0x14D0AA1 VA: 0x14D09A0
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406F0 Offset: 0x1407F1 VA: 0x1406F0
	// RVA: 0x14D0A90 Offset: 0x14D0B91 VA: 0x14D0A90 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140700 Offset: 0x140801 VA: 0x140700
	// RVA: 0x14D0B40 Offset: 0x14D0C41 VA: 0x14D0B40 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x14D0BF0 Offset: 0x14D0CF1 VA: 0x14D0BF0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x14D0D00 Offset: 0x14D0E01 VA: 0x14D0D00 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x14D0D10 Offset: 0x14D0E11 VA: 0x14D0D10 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x14D0D20 Offset: 0x14D0E21 VA: 0x14D0D20 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x14D0D30 Offset: 0x14D0E31 VA: 0x14D0D30 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x14D0D40 Offset: 0x14D0E41 VA: 0x14D0D40
	public float get_maxWidth() { }

	// RVA: 0x14D0D50 Offset: 0x14D0E51 VA: 0x14D0D50
	public float get_maxHeight() { }

	// RVA: 0x14D0D60 Offset: 0x14D0E61 VA: 0x14D0D60
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x14D0E10 Offset: 0x14D0F11 VA: 0x14D0E10 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x14D0FB0 Offset: 0x14D10B1 VA: 0x14D0FB0 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x14D1190 Offset: 0x14D1291 VA: 0x14D1190 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x14D11B0 Offset: 0x14D12B1 VA: 0x14D11B0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x14D11F0 Offset: 0x14D12F1 VA: 0x14D11F0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x14D1200 Offset: 0x14D1301 VA: 0x14D1200 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x14D1210 Offset: 0x14D1311 VA: 0x14D1210 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x14D1220 Offset: 0x14D1321 VA: 0x14D1220 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x14D1230 Offset: 0x14D1331 VA: 0x14D1230 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x14D1240 Offset: 0x14D1341 VA: 0x14D1240 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x14D1250 Offset: 0x14D1351 VA: 0x14D1250 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x14D1260 Offset: 0x14D1361 VA: 0x14D1260 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x14D1270 Offset: 0x14D1371 VA: 0x14D1270 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x14D1330 Offset: 0x14D1431 VA: 0x14D1330
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x14D1430 Offset: 0x14D1531 VA: 0x14D1430
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x14D1440 Offset: 0x14D1541 VA: 0x14D1440
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x14D1450 Offset: 0x14D1551 VA: 0x14D1450 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x14D1460 Offset: 0x14D1561 VA: 0x14D1460 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x14D1470 Offset: 0x14D1571 VA: 0x14D1470 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x14D1480 Offset: 0x14D1581 VA: 0x14D1480 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x14D1490 Offset: 0x14D1591 VA: 0x14D1490 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x14D14A0 Offset: 0x14D15A1 VA: 0x14D14A0 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x14D14B0 Offset: 0x14D15B1 VA: 0x14D14B0 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x14D15F0 Offset: 0x14D16F1 VA: 0x14D15F0 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x14D1710 Offset: 0x14D1811 VA: 0x14D1710 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x14D1720 Offset: 0x14D1821 VA: 0x14D1720 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x14D1730 Offset: 0x14D1831 VA: 0x14D1730
	internal void SetTextInternal(string text) { }

	// RVA: 0x14D1790 Offset: 0x14D1891 VA: 0x14D1790 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x14D17A0 Offset: 0x14D18A1 VA: 0x14D17A0 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x14D17B0 Offset: 0x14D18B1 VA: 0x14D17B0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x14D17C0 Offset: 0x14D18C1 VA: 0x14D17C0 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x14D17D0 Offset: 0x14D18D1 VA: 0x14D17D0 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x14D17E0 Offset: 0x14D18E1 VA: 0x14D17E0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D1880 Offset: 0x14D1981 VA: 0x14D1880 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D18E0 Offset: 0x14D19E1 VA: 0x14D18E0 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D18F0 Offset: 0x14D19F1 VA: 0x14D18F0 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D1900 Offset: 0x14D1A01 VA: 0x14D1900
	protected void ParseInputText() { }

	// RVA: 0x14D2CD0 Offset: 0x14D2DD1 VA: 0x14D2CD0
	public void SetText(string text, bool syncTextInputBox = True) { }

	// RVA: 0x14D2CE0 Offset: 0x14D2DE1 VA: 0x14D2CE0
	public void SetText(string text, float arg0) { }

	// RVA: 0x14D2FF0 Offset: 0x14D30F1 VA: 0x14D2FF0
	public void SetText(string text, float arg0, float arg1) { }

	// RVA: 0x14D3010 Offset: 0x14D3111 VA: 0x14D3010
	public void SetText(string text, float arg0, float arg1, float arg2) { }

	// RVA: 0x14D3030 Offset: 0x14D3131 VA: 0x14D3030
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x14D3050 Offset: 0x14D3151 VA: 0x14D3050
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x14D3060 Offset: 0x14D3161 VA: 0x14D3060
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x14D3070 Offset: 0x14D3171 VA: 0x14D3070
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x14D2D00 Offset: 0x14D2E01 VA: 0x14D2D00
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x14D33D0 Offset: 0x14D34D1 VA: 0x14D33D0
	public void SetText(StringBuilder text) { }

	// RVA: 0x14D3DD0 Offset: 0x14D3ED1 VA: 0x14D3DD0
	public void SetText(char[] text) { }

	// RVA: 0x14D4460 Offset: 0x14D4561 VA: 0x14D4460
	public void SetText(char[] text, int start, int length) { }

	// RVA: 0x14D3DE0 Offset: 0x14D3EE1 VA: 0x14D3DE0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x14D4470 Offset: 0x14D4571 VA: 0x14D4470
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x14D5E70 Offset: 0x14D5F71 VA: 0x14D5E70
	public void SetCharArray(int[] sourceText, int start, int length) { }

	// RVA: 0x14D2640 Offset: 0x14D2741 VA: 0x14D2640
	protected int CharArrayToInternalParsingBuffer(char[] sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D1A30 Offset: 0x14D1B31 VA: 0x14D1A30
	protected int StringToInternalParsingBuffer(string sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D3430 Offset: 0x14D3531 VA: 0x14D3430
	protected int StringBuilderToInternalParsingBuffer(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D7240 Offset: 0x14D7341 VA: 0x14D7240
	private bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D65F0 Offset: 0x14D66F1 VA: 0x14D65F0
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D50E0 Offset: 0x14D51E1 VA: 0x14D50E0
	private bool ReplaceOpeningStyleTag(ref char[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7E90 Offset: 0x14D7F91 VA: 0x14D7E90
	private bool ReplaceOpeningStyleTag(ref StringBuilder sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D76F0 Offset: 0x14D77F1 VA: 0x14D76F0
	private bool ReplaceClosingStyleTag(ref string sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D6AA0 Offset: 0x14D6BA1 VA: 0x14D6AA0
	private bool ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5590 Offset: 0x14D5691 VA: 0x14D5590
	private bool ReplaceClosingStyleTag(ref char[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D8330 Offset: 0x14D8431 VA: 0x14D8330
	private bool ReplaceClosingStyleTag(ref StringBuilder sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14CE670 Offset: 0x14CE771 VA: 0x14CE670
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x14D4B50 Offset: 0x14D4C51 VA: 0x14D4B50
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5A10 Offset: 0x14D5B11 VA: 0x14D5A10
	private bool InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7130 Offset: 0x14D7231 VA: 0x14D7130
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0x14D4FB0 Offset: 0x14D50B1 VA: 0x14D4FB0
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0x14D64C0 Offset: 0x14D65C1 VA: 0x14D64C0
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0x14D7D80 Offset: 0x14D7E81 VA: 0x14D7D80
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0x14D87B0 Offset: 0x14D88B1 VA: 0x14D87B0
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0x14D8BE0 Offset: 0x14D8CE1 VA: 0x14D8BE0
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8AE0 Offset: 0x14D8BE1 VA: 0x14D8AE0
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8CE0 Offset: 0x14D8DE1 VA: 0x14D8CE0
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1B90 Offset: 0x23E1C91 VA: 0x23E1B90
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1CC0 Offset: 0x23E1DC1 VA: 0x23E1CC0
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1C30 Offset: 0x23E1D31 VA: 0x23E1C30
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1D60 Offset: 0x23E1E61 VA: 0x23E1D60
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x14D3080 Offset: 0x14D3181 VA: 0x14D3080
	private void AddFloatToCharArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x14D8E00 Offset: 0x14D8F01 VA: 0x14D8E00
	private void AddIntegerToCharArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x14D8F60 Offset: 0x14D9061 VA: 0x14D8F60 Slot: 114
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x14D8F70 Offset: 0x14D9071 VA: 0x14D8F70 Slot: 115
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x14D8F80 Offset: 0x14D9081 VA: 0x14D8F80
	public Vector2 GetPreferredValues() { }

	// RVA: 0x14D9000 Offset: 0x14D9101 VA: 0x14D9000
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x14D9290 Offset: 0x14D9391 VA: 0x14D9290
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x14D9440 Offset: 0x14D9541 VA: 0x14D9440
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x14D0E40 Offset: 0x14D0F41 VA: 0x14D0E40
	protected float GetPreferredWidth() { }

	// RVA: 0x14D9170 Offset: 0x14D9271 VA: 0x14D9170
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x14D0FE0 Offset: 0x14D10E1 VA: 0x14D0FE0
	protected float GetPreferredHeight() { }

	// RVA: 0x14D91E0 Offset: 0x14D92E1 VA: 0x14D91E0
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x14D95C0 Offset: 0x14D96C1 VA: 0x14D95C0
	public Vector2 GetRenderedValues() { }

	// RVA: 0x14D9690 Offset: 0x14D9791 VA: 0x14D9690
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11A0 Offset: 0x14D12A1 VA: 0x14D11A0
	private float GetRenderedWidth() { }

	// RVA: 0x14D9A90 Offset: 0x14D9B91 VA: 0x14D9A90
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11D0 Offset: 0x14D12D1 VA: 0x14D11D0
	private float GetRenderedHeight() { }

	// RVA: 0x14D9AA0 Offset: 0x14D9BA1 VA: 0x14D9AA0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x14D9AC0 Offset: 0x14D9BC1 VA: 0x14D9AC0 Slot: 116
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x14E17A0 Offset: 0x14E18A1 VA: 0x14E17A0 Slot: 117
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x14E17B0 Offset: 0x14E18B1 VA: 0x14E17B0 Slot: 118
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x14D0410 Offset: 0x14D0511 VA: 0x14D0410
	protected Bounds GetTextBounds() { }

	// RVA: 0x14D9770 Offset: 0x14D9871 VA: 0x14D9770
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x14E17C0 Offset: 0x14E18C1 VA: 0x14E17C0
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x14E1BE0 Offset: 0x14E1CE1 VA: 0x14E1BE0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x14E1E70 Offset: 0x14E1F71 VA: 0x14E1E70 Slot: 119
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x14E1E80 Offset: 0x14E1F81 VA: 0x14E1E80 Slot: 120
	public virtual void ComputeMarginSize() { }

	// RVA: 0x14E1E90 Offset: 0x14E1F91 VA: 0x14E1E90
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x14E1390 Offset: 0x14E1491 VA: 0x14E1390
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x14E0EE0 Offset: 0x14E0FE1 VA: 0x14E0EE0
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x14E2580 Offset: 0x14E2681 VA: 0x14E2580 Slot: 121
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x14E30E0 Offset: 0x14E31E1 VA: 0x14E30E0 Slot: 122
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x14E38B0 Offset: 0x14E39B1 VA: 0x14E38B0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E4000 Offset: 0x14E4101 VA: 0x14E4000 Slot: 124
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x14E4F20 Offset: 0x14E5021 VA: 0x14E4F20 Slot: 125
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E5670 Offset: 0x14E5771 VA: 0x14E5670 Slot: 126
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x14E68A0 Offset: 0x14E69A1 VA: 0x14E68A0 Slot: 127
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x14E6E20 Offset: 0x14E6F21 VA: 0x14E6E20
	protected void LoadDefaultSettings() { }

	// RVA: 0x14E71E0 Offset: 0x14E72E1 VA: 0x14E71E0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7210 Offset: 0x14E7311 VA: 0x14E7210
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E6700 Offset: 0x14E6801 VA: 0x14E6700
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7490 Offset: 0x14E7591 VA: 0x14E7490
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x14E7520 Offset: 0x14E7621 VA: 0x14E7520
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x14E75B0 Offset: 0x14E76B1 VA: 0x14E75B0
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x14E79C0 Offset: 0x14E7AC1 VA: 0x14E79C0 Slot: 128
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x14E79D0 Offset: 0x14E7AD1 VA: 0x14E79D0 Slot: 129
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x14E79E0 Offset: 0x14E7AE1 VA: 0x14E79E0 Slot: 130
	public virtual void ClearMesh() { }

	// RVA: 0x14E79F0 Offset: 0x14E7AF1 VA: 0x14E79F0 Slot: 131
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x14E7A00 Offset: 0x14E7B01 VA: 0x14E7A00 Slot: 132
	public virtual string GetParsedText() { }

	// RVA: 0x14CF940 Offset: 0x14CFA41 VA: 0x14CF940
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x14CF800 Offset: 0x14CF901 VA: 0x14CF800
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x14E6860 Offset: 0x14E6961 VA: 0x14E6860
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x14E7B20 Offset: 0x14E7C21 VA: 0x14E7B20
	protected float PackUV(float x, float y) { }

	// RVA: 0x14E7B60 Offset: 0x14E7C61 VA: 0x14E7B60 Slot: 133
	internal virtual void InternalUpdate() { }

	// RVA: 0x14E7B70 Offset: 0x14E7C71 VA: 0x14E7B70
	protected int HexToInt(char hex) { }

	// RVA: 0x14D7070 Offset: 0x14D7171 VA: 0x14D7070
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x14D88D0 Offset: 0x14D89D1 VA: 0x14D88D0
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x14D7CC0 Offset: 0x14D7DC1 VA: 0x14D7CC0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x14D6F20 Offset: 0x14D7021 VA: 0x14D6F20
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x14D8990 Offset: 0x14D8A91 VA: 0x14D8990
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x14D7B70 Offset: 0x14D7C71 VA: 0x14D7B70
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x14E7BA0 Offset: 0x14E7CA1 VA: 0x14E7BA0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x14E8000 Offset: 0x14E8101 VA: 0x14E8000
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x14E8290 Offset: 0x14E8391 VA: 0x14E8290
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x14E8540 Offset: 0x14E8641 VA: 0x14E8540
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x14E8350 Offset: 0x14E8451 VA: 0x14E8350
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x14DC210 Offset: 0x14DC311 VA: 0x14DC210
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x14E8570 Offset: 0x14E8671 VA: 0x14E8570
	protected void .ctor() { }

	// RVA: 0x14E9110 Offset: 0x14E9211 VA: 0x14E9110
	private static void .cctor() { }
}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 5864
{
	// Fields
	[SerializeField] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	[TextAreaAttribute] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	protected string m_text; // 0xC0
	[SerializeField] // RVA: 0x13FE90 Offset: 0x13FF91 VA: 0x13FE90
	protected ITextPreprocessor m_TextPreprocessor; // 0xC8
	[SerializeField] // RVA: 0x13FEA0 Offset: 0x13FFA1 VA: 0x13FEA0
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x13FEB0 Offset: 0x13FFB1 VA: 0x13FEB0
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x13FEC0 Offset: 0x13FFC1 VA: 0x13FEC0
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x168
	[SerializeField] // RVA: 0x13FED0 Offset: 0x13FFD1 VA: 0x13FED0
	protected Material[] m_fontSharedMaterials; // 0x170
	[SerializeField] // RVA: 0x13FEE0 Offset: 0x13FFE1 VA: 0x13FEE0
	protected Material m_fontMaterial; // 0x178
	[SerializeField] // RVA: 0x13FEF0 Offset: 0x13FFF1 VA: 0x13FEF0
	protected Material[] m_fontMaterials; // 0x180
	protected bool m_isMaterialDirty; // 0x188
	[SerializeField] // RVA: 0x13FF00 Offset: 0x140001 VA: 0x13FF00
	protected Color32 m_fontColor32; // 0x18C
	[SerializeField] // RVA: 0x13FF10 Offset: 0x140011 VA: 0x13FF10
	protected Color m_fontColor; // 0x190
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x1A0
	protected Color32 m_strikethroughColor; // 0x1A4
	[SerializeField] // RVA: 0x13FF20 Offset: 0x140021 VA: 0x13FF20
	protected bool m_enableVertexGradient; // 0x1A8
	[SerializeField] // RVA: 0x13FF30 Offset: 0x140031 VA: 0x13FF30
	protected ColorMode m_colorMode; // 0x1AC
	[SerializeField] // RVA: 0x13FF40 Offset: 0x140041 VA: 0x13FF40
	protected VertexGradient m_fontColorGradient; // 0x1B0
	[SerializeField] // RVA: 0x13FF50 Offset: 0x140051 VA: 0x13FF50
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x13FF60 Offset: 0x140061 VA: 0x13FF60
	protected TMP_SpriteAsset m_spriteAsset; // 0x1F8
	[SerializeField] // RVA: 0x13FF70 Offset: 0x140071 VA: 0x13FF70
	protected bool m_tintAllSprites; // 0x200
	protected bool m_tintSprite; // 0x201
	protected Color32 m_spriteColor; // 0x204
	[SerializeField] // RVA: 0x13FF80 Offset: 0x140081 VA: 0x13FF80
	protected TMP_StyleSheet m_StyleSheet; // 0x208
	internal TMP_Style m_TextStyle; // 0x210
	[SerializeField] // RVA: 0x13FF90 Offset: 0x140091 VA: 0x13FF90
	protected int m_TextStyleHashCode; // 0x218
	[SerializeField] // RVA: 0x13FFA0 Offset: 0x1400A1 VA: 0x13FFA0
	protected bool m_overrideHtmlColors; // 0x21C
	[SerializeField] // RVA: 0x13FFB0 Offset: 0x1400B1 VA: 0x13FFB0
	protected Color32 m_faceColor; // 0x220
	protected Color32 m_outlineColor; // 0x224
	protected float m_outlineWidth; // 0x228
	[SerializeField] // RVA: 0x13FFC0 Offset: 0x1400C1 VA: 0x13FFC0
	protected float m_fontSize; // 0x22C
	protected float m_currentFontSize; // 0x230
	[SerializeField] // RVA: 0x13FFD0 Offset: 0x1400D1 VA: 0x13FFD0
	protected float m_fontSizeBase; // 0x234
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x238
	[SerializeField] // RVA: 0x13FFE0 Offset: 0x1400E1 VA: 0x13FFE0
	protected FontWeight m_fontWeight; // 0x258
	protected FontWeight m_FontWeightInternal; // 0x25C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x260
	[SerializeField] // RVA: 0x13FFF0 Offset: 0x1400F1 VA: 0x13FFF0
	protected bool m_enableAutoSizing; // 0x280
	protected float m_maxFontSize; // 0x284
	protected float m_minFontSize; // 0x288
	protected int m_AutoSizeIterationCount; // 0x28C
	protected int m_AutoSizeMaxIterationCount; // 0x290
	protected bool m_IsAutoSizePointSizeSet; // 0x294
	[SerializeField] // RVA: 0x140000 Offset: 0x140101 VA: 0x140000
	protected float m_fontSizeMin; // 0x298
	[SerializeField] // RVA: 0x140010 Offset: 0x140111 VA: 0x140010
	protected float m_fontSizeMax; // 0x29C
	[SerializeField] // RVA: 0x140020 Offset: 0x140121 VA: 0x140020
	protected FontStyles m_fontStyle; // 0x2A0
	protected FontStyles m_FontStyleInternal; // 0x2A4
	protected TMP_FontStyleStack m_fontStyleStack; // 0x2A8
	protected bool m_isUsingBold; // 0x2B2
	[SerializeField] // RVA: 0x140030 Offset: 0x140131 VA: 0x140030
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x2B4
	[SerializeField] // RVA: 0x140040 Offset: 0x140141 VA: 0x140040
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x2B8
	[SerializeField] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	[FormerlySerializedAsAttribute] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	protected TextAlignmentOptions m_textAlignment; // 0x2BC
	protected HorizontalAlignmentOptions m_lineJustification; // 0x2C0
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2C8
	protected Vector3[] m_textContainerLocalCorners; // 0x2E8
	[SerializeField] // RVA: 0x1400A0 Offset: 0x1401A1 VA: 0x1400A0
	protected float m_characterSpacing; // 0x2F0
	protected float m_cSpacing; // 0x2F4
	protected float m_monoSpacing; // 0x2F8
	[SerializeField] // RVA: 0x1400B0 Offset: 0x1401B1 VA: 0x1400B0
	protected float m_wordSpacing; // 0x2FC
	[SerializeField] // RVA: 0x1400C0 Offset: 0x1401C1 VA: 0x1400C0
	protected float m_lineSpacing; // 0x300
	protected float m_lineSpacingDelta; // 0x304
	protected float m_lineHeight; // 0x308
	protected bool m_IsDrivenLineSpacing; // 0x30C
	[SerializeField] // RVA: 0x1400D0 Offset: 0x1401D1 VA: 0x1400D0
	protected float m_lineSpacingMax; // 0x310
	[SerializeField] // RVA: 0x1400E0 Offset: 0x1401E1 VA: 0x1400E0
	protected float m_paragraphSpacing; // 0x314
	[SerializeField] // RVA: 0x1400F0 Offset: 0x1401F1 VA: 0x1400F0
	protected float m_charWidthMaxAdj; // 0x318
	protected float m_charWidthAdjDelta; // 0x31C
	[SerializeField] // RVA: 0x140100 Offset: 0x140201 VA: 0x140100
	protected bool m_enableWordWrapping; // 0x320
	protected bool m_isCharacterWrappingEnabled; // 0x321
	protected bool m_isNonBreakingSpace; // 0x322
	protected bool m_isIgnoringAlignment; // 0x323
	[SerializeField] // RVA: 0x140110 Offset: 0x140211 VA: 0x140110
	protected float m_wordWrappingRatios; // 0x324
	[SerializeField] // RVA: 0x140120 Offset: 0x140221 VA: 0x140120
	protected TextOverflowModes m_overflowMode; // 0x328
	protected int m_firstOverflowCharacterIndex; // 0x32C
	[SerializeField] // RVA: 0x140130 Offset: 0x140231 VA: 0x140130
	protected TMP_Text m_linkedTextComponent; // 0x330
	[SerializeField] // RVA: 0x140140 Offset: 0x140241 VA: 0x140140
	internal TMP_Text parentLinkedComponent; // 0x338
	protected bool m_isTextTruncated; // 0x340
	[SerializeField] // RVA: 0x140150 Offset: 0x140251 VA: 0x140150
	protected bool m_enableKerning; // 0x341
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x344
	[SerializeField] // RVA: 0x140160 Offset: 0x140261 VA: 0x140160
	protected bool m_enableExtraPadding; // 0x348
	[SerializeField] // RVA: 0x140170 Offset: 0x140271 VA: 0x140170
	protected bool checkPaddingRequired; // 0x349
	[SerializeField] // RVA: 0x140180 Offset: 0x140281 VA: 0x140180
	protected bool m_isRichText; // 0x34A
	[SerializeField] // RVA: 0x140190 Offset: 0x140291 VA: 0x140190
	protected bool m_parseCtrlCharacters; // 0x34B
	protected bool m_isOverlay; // 0x34C
	[SerializeField] // RVA: 0x1401A0 Offset: 0x1402A1 VA: 0x1401A0
	protected bool m_isOrthographic; // 0x34D
	[SerializeField] // RVA: 0x1401B0 Offset: 0x1402B1 VA: 0x1401B0
	protected bool m_isCullingEnabled; // 0x34E
	protected bool m_isMaskingEnabled; // 0x34F
	protected bool isMaskUpdateRequired; // 0x350
	protected bool m_ignoreCulling; // 0x351
	[SerializeField] // RVA: 0x1401C0 Offset: 0x1402C1 VA: 0x1401C0
	protected TextureMappingOptions m_horizontalMapping; // 0x354
	[SerializeField] // RVA: 0x1401D0 Offset: 0x1402D1 VA: 0x1401D0
	protected TextureMappingOptions m_verticalMapping; // 0x358
	[SerializeField] // RVA: 0x1401E0 Offset: 0x1402E1 VA: 0x1401E0
	protected float m_uvLineOffset; // 0x35C
	protected TextRenderFlags m_renderMode; // 0x360
	[SerializeField] // RVA: 0x1401F0 Offset: 0x1402F1 VA: 0x1401F0
	protected VertexSortingOrder m_geometrySortingOrder; // 0x364
	[SerializeField] // RVA: 0x140200 Offset: 0x140301 VA: 0x140200
	protected bool m_IsTextObjectScaleStatic; // 0x368
	[SerializeField] // RVA: 0x140210 Offset: 0x140311 VA: 0x140210
	protected bool m_VertexBufferAutoSizeReduction; // 0x369
	protected int m_firstVisibleCharacter; // 0x36C
	protected int m_maxVisibleCharacters; // 0x370
	protected int m_maxVisibleWords; // 0x374
	protected int m_maxVisibleLines; // 0x378
	[SerializeField] // RVA: 0x140220 Offset: 0x140321 VA: 0x140220
	protected bool m_useMaxVisibleDescender; // 0x37C
	[SerializeField] // RVA: 0x140230 Offset: 0x140331 VA: 0x140230
	protected int m_pageToDisplay; // 0x380
	protected bool m_isNewPage; // 0x384
	[SerializeField] // RVA: 0x140240 Offset: 0x140341 VA: 0x140240
	protected Vector4 m_margin; // 0x388
	protected float m_marginLeft; // 0x398
	protected float m_marginRight; // 0x39C
	protected float m_marginWidth; // 0x3A0
	protected float m_marginHeight; // 0x3A4
	protected float m_width; // 0x3A8
	protected TMP_TextInfo m_textInfo; // 0x3B0
	protected bool m_havePropertiesChanged; // 0x3B8
	[SerializeField] // RVA: 0x140250 Offset: 0x140351 VA: 0x140250
	protected bool m_isUsingLegacyAnimationComponent; // 0x3B9
	protected Transform m_transform; // 0x3C0
	protected RectTransform m_rectTransform; // 0x3C8
	protected Vector2 m_PreviousRectTransformSize; // 0x3D0
	protected Vector2 m_PreviousPivotPosition; // 0x3D8
	[CompilerGeneratedAttribute] // RVA: 0x140260 Offset: 0x140361 VA: 0x140260
	private bool <autoSizeTextContainer>k__BackingField; // 0x3E0
	protected bool m_autoSizeTextContainer; // 0x3E1
	protected Mesh m_mesh; // 0x3E8
	[SerializeField] // RVA: 0x140270 Offset: 0x140371 VA: 0x140270
	protected bool m_isVolumetricText; // 0x3F0
	[CompilerGeneratedAttribute] // RVA: 0x140280 Offset: 0x140381 VA: 0x140280
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x140290 Offset: 0x140391 VA: 0x140290
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1402A0 Offset: 0x1403A1 VA: 0x1402A0
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3F8
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x400
	protected float m_flexibleHeight; // 0x408
	protected float m_flexibleWidth; // 0x40C
	protected float m_minWidth; // 0x410
	protected float m_minHeight; // 0x414
	protected float m_maxWidth; // 0x418
	protected float m_maxHeight; // 0x41C
	protected LayoutElement m_LayoutElement; // 0x420
	protected float m_preferredWidth; // 0x428
	protected float m_renderedWidth; // 0x42C
	protected bool m_isPreferredWidthDirty; // 0x430
	protected float m_preferredHeight; // 0x434
	protected float m_renderedHeight; // 0x438
	protected bool m_isPreferredHeightDirty; // 0x43C
	protected bool m_isCalculatingPreferredValues; // 0x43D
	protected int m_layoutPriority; // 0x440
	protected bool m_isLayoutDirty; // 0x444
	protected bool m_isAwake; // 0x445
	internal bool m_isWaitingOnResourceLoad; // 0x446
	internal bool m_isInputParsingRequired; // 0x447
	internal TMP_Text.TextInputSources m_inputSource; // 0x448
	protected float m_fontScale; // 0x44C
	protected float m_fontScaleMultiplier; // 0x450
	protected char[] m_htmlTag; // 0x458
	protected RichTextTagAttribute[] m_xmlAttribute; // 0x460
	protected float[] m_attributeParameterValues; // 0x468
	protected float tag_LineIndent; // 0x470
	protected float tag_Indent; // 0x474
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x478
	protected bool tag_NoParsing; // 0x498
	protected bool m_isParsingText; // 0x499
	protected Matrix4x4 m_FXMatrix; // 0x49C
	protected bool m_isFXMatrixSet; // 0x4DC
	protected TMP_Text.UnicodeChar[] m_InternalParsingBuffer; // 0x4E0
	protected int m_InternalParsingBufferSize; // 0x4E8
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x4F0
	protected char[] m_input_CharArray; // 0x4F8
	private int m_charArray_Length; // 0x500
	protected int m_totalCharacterCount; // 0x504
	protected WordWrapState m_SavedWordWrapState; // 0x508
	protected WordWrapState m_SavedLineState; // 0x880
	protected WordWrapState m_SavedEllipsisState; // 0xBF8
	protected WordWrapState m_SavedLastValidState; // 0xF70
	protected WordWrapState m_SavedSoftLineBreakState; // 0x12E8
	internal TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1660
	protected int m_characterCount; // 0x19F8
	protected int m_firstCharacterOfLine; // 0x19FC
	protected int m_firstVisibleCharacterOfLine; // 0x1A00
	protected int m_lastCharacterOfLine; // 0x1A04
	protected int m_lastVisibleCharacterOfLine; // 0x1A08
	protected int m_lineNumber; // 0x1A0C
	protected int m_lineVisibleCharacterCount; // 0x1A10
	protected int m_pageNumber; // 0x1A14
	protected float m_PageAscender; // 0x1A18
	protected float m_maxTextAscender; // 0x1A1C
	protected float m_maxCapHeight; // 0x1A20
	protected float m_ElementAscender; // 0x1A24
	protected float m_ElementDescender; // 0x1A28
	protected float m_maxLineAscender; // 0x1A2C
	protected float m_maxLineDescender; // 0x1A30
	protected float m_startOfLineAscender; // 0x1A34
	protected float m_startOfLineDescender; // 0x1A38
	protected float m_lineOffset; // 0x1A3C
	protected Extents m_meshExtents; // 0x1A40
	protected Color32 m_htmlColor; // 0x1A50
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x1A58
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x1A78
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x1A98
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x1AB8
	protected TMP_ColorGradient m_colorGradientPreset; // 0x1AE8
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x1AF0
	protected bool m_colorGradientPresetIsTinted; // 0x1B18
	protected float m_tabSpacing; // 0x1B1C
	protected float m_spacing; // 0x1B20
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x1B28
	protected int m_TextStyleStackDepth; // 0x1B30
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x1B38
	protected int m_ItalicAngle; // 0x1B58
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x1B60
	protected float m_padding; // 0x1B80
	protected float m_baselineOffset; // 0x1B84
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x1B88
	protected float m_xAdvance; // 0x1BA8
	protected TMP_TextElementType m_textElementType; // 0x1BAC
	protected TMP_TextElement m_cached_TextElement; // 0x1BB0
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x1BB8
	protected TMP_Text.SpecialCharacter m_Underline; // 0x1BD8
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x1BF8
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x1C00
	protected int m_spriteCount; // 0x1C08
	protected int m_spriteIndex; // 0x1C0C
	protected int m_spriteAnimationID; // 0x1C10
	protected bool m_ignoreActiveState; // 0x1C14
	private readonly Decimal[] k_Power; // 0x1C18
	protected static Vector2 k_LargePositiveVector2; // 0x18
	protected static Vector2 k_LargeNegativeVector2; // 0x20
	protected static float k_LargePositiveFloat; // 0x28
	protected static float k_LargeNegativeFloat; // 0x2C
	protected static int k_LargePositiveInt; // 0x30
	protected static int k_LargeNegativeInt; // 0x34

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public float fontScale { get; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x14CDCA0 Offset: 0x14CDDA1 VA: 0x14CDCA0 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x14CDCB0 Offset: 0x14CDDB1 VA: 0x14CDCB0 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x14CDD60 Offset: 0x14CDE61 VA: 0x14CDD60
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x14CDD70 Offset: 0x14CDE71 VA: 0x14CDD70
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x14CDD80 Offset: 0x14CDE81 VA: 0x14CDD80
	public bool get_isRightToLeftText() { }

	// RVA: 0x14CDD90 Offset: 0x14CDE91 VA: 0x14CDD90
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x14CDE00 Offset: 0x14CDF01 VA: 0x14CDE00
	public TMP_FontAsset get_font() { }

	// RVA: 0x14CDE10 Offset: 0x14CDF11 VA: 0x14CDE10
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x14CDF00 Offset: 0x14CE001 VA: 0x14CDF00 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x14CDF10 Offset: 0x14CE011 VA: 0x14CDF10 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x14CDFF0 Offset: 0x14CE0F1 VA: 0x14CDFF0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x14CE000 Offset: 0x14CE101 VA: 0x14CE000 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x14CE060 Offset: 0x14CE161 VA: 0x14CE060
	public Material get_fontMaterial() { }

	// RVA: 0x14CE080 Offset: 0x14CE181 VA: 0x14CE080
	public void set_fontMaterial(Material value) { }

	// RVA: 0x14CE1A0 Offset: 0x14CE2A1 VA: 0x14CE1A0 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x14CE1C0 Offset: 0x14CE2C1 VA: 0x14CE1C0 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x14CE220 Offset: 0x14CE321 VA: 0x14CE220 Slot: 22
	public override Color get_color() { }

	// RVA: 0x14CE240 Offset: 0x14CE341 VA: 0x14CE240 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x14CE2F0 Offset: 0x14CE3F1 VA: 0x14CE2F0
	public float get_alpha() { }

	// RVA: 0x14CE300 Offset: 0x14CE401 VA: 0x14CE300
	public void set_alpha(float value) { }

	// RVA: 0x14CE330 Offset: 0x14CE431 VA: 0x14CE330
	public bool get_enableVertexGradient() { }

	// RVA: 0x14CE340 Offset: 0x14CE441 VA: 0x14CE340
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x14CE380 Offset: 0x14CE481 VA: 0x14CE380
	public VertexGradient get_colorGradient() { }

	// RVA: 0x14CE3B0 Offset: 0x14CE4B1 VA: 0x14CE3B0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x14CE3F0 Offset: 0x14CE4F1 VA: 0x14CE3F0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x14CE400 Offset: 0x14CE501 VA: 0x14CE400
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x14CE440 Offset: 0x14CE541 VA: 0x14CE440
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x14CE450 Offset: 0x14CE551 VA: 0x14CE450
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x14CE4B0 Offset: 0x14CE5B1 VA: 0x14CE4B0
	public bool get_tintAllSprites() { }

	// RVA: 0x14CE4C0 Offset: 0x14CE5C1 VA: 0x14CE4C0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x14CE500 Offset: 0x14CE601 VA: 0x14CE500
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x14CE510 Offset: 0x14CE611 VA: 0x14CE510
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x14CE570 Offset: 0x14CE671 VA: 0x14CE570
	public TMP_Style get_textStyle() { }

	// RVA: 0x14CE830 Offset: 0x14CE931 VA: 0x14CE830
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x14CE8A0 Offset: 0x14CE9A1 VA: 0x14CE8A0
	public bool get_overrideColorTags() { }

	// RVA: 0x14CE8B0 Offset: 0x14CE9B1 VA: 0x14CE8B0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x14CE8F0 Offset: 0x14CE9F1 VA: 0x14CE8F0
	public Color32 get_faceColor() { }

	// RVA: 0x14CE9E0 Offset: 0x14CEAE1 VA: 0x14CE9E0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x14CEA80 Offset: 0x14CEB81 VA: 0x14CEA80
	public Color32 get_outlineColor() { }

	// RVA: 0x14CEB70 Offset: 0x14CEC71 VA: 0x14CEB70
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x14CEC00 Offset: 0x14CED01 VA: 0x14CEC00
	public float get_outlineWidth() { }

	// RVA: 0x14CECE0 Offset: 0x14CEDE1 VA: 0x14CECE0
	public void set_outlineWidth(float value) { }

	// RVA: 0x14CED60 Offset: 0x14CEE61 VA: 0x14CED60
	public float get_fontSize() { }

	// RVA: 0x14CED70 Offset: 0x14CEE71 VA: 0x14CED70
	public void set_fontSize(float value) { }

	// RVA: 0x14CEDE0 Offset: 0x14CEEE1 VA: 0x14CEDE0
	public float get_fontScale() { }

	// RVA: 0x14CEDF0 Offset: 0x14CEEF1 VA: 0x14CEDF0
	public FontWeight get_fontWeight() { }

	// RVA: 0x14CEE00 Offset: 0x14CEF01 VA: 0x14CEE00
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x14CEE60 Offset: 0x14CEF61 VA: 0x14CEE60
	public float get_pixelsPerUnit() { }

	// RVA: 0x14CF010 Offset: 0x14CF111 VA: 0x14CF010
	public bool get_enableAutoSizing() { }

	// RVA: 0x14CF020 Offset: 0x14CF121 VA: 0x14CF020
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x14CF080 Offset: 0x14CF181 VA: 0x14CF080
	public float get_fontSizeMin() { }

	// RVA: 0x14CF090 Offset: 0x14CF191 VA: 0x14CF090
	public void set_fontSizeMin(float value) { }

	// RVA: 0x14CF0E0 Offset: 0x14CF1E1 VA: 0x14CF0E0
	public float get_fontSizeMax() { }

	// RVA: 0x14CF0F0 Offset: 0x14CF1F1 VA: 0x14CF0F0
	public void set_fontSizeMax(float value) { }

	// RVA: 0x14CF140 Offset: 0x14CF241 VA: 0x14CF140
	public FontStyles get_fontStyle() { }

	// RVA: 0x14CF150 Offset: 0x14CF251 VA: 0x14CF150
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x14CF1B0 Offset: 0x14CF2B1 VA: 0x14CF1B0
	public bool get_isUsingBold() { }

	// RVA: 0x14CF1C0 Offset: 0x14CF2C1 VA: 0x14CF1C0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x14CF1D0 Offset: 0x14CF2D1 VA: 0x14CF1D0
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x14CF200 Offset: 0x14CF301 VA: 0x14CF200
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x14CF210 Offset: 0x14CF311 VA: 0x14CF210
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x14CF240 Offset: 0x14CF341 VA: 0x14CF240
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x14CF250 Offset: 0x14CF351 VA: 0x14CF250
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x14CF2A0 Offset: 0x14CF3A1 VA: 0x14CF2A0
	public float get_characterSpacing() { }

	// RVA: 0x14CF2B0 Offset: 0x14CF3B1 VA: 0x14CF2B0
	public void set_characterSpacing(float value) { }

	// RVA: 0x14CF310 Offset: 0x14CF411 VA: 0x14CF310
	public float get_wordSpacing() { }

	// RVA: 0x14CF320 Offset: 0x14CF421 VA: 0x14CF320
	public void set_wordSpacing(float value) { }

	// RVA: 0x14CF380 Offset: 0x14CF481 VA: 0x14CF380
	public float get_lineSpacing() { }

	// RVA: 0x14CF390 Offset: 0x14CF491 VA: 0x14CF390
	public void set_lineSpacing(float value) { }

	// RVA: 0x14CF3F0 Offset: 0x14CF4F1 VA: 0x14CF3F0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x14CF400 Offset: 0x14CF501 VA: 0x14CF400
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x14CF460 Offset: 0x14CF561 VA: 0x14CF460
	public float get_paragraphSpacing() { }

	// RVA: 0x14CF470 Offset: 0x14CF571 VA: 0x14CF470
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x14CF4D0 Offset: 0x14CF5D1 VA: 0x14CF4D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x14CF4E0 Offset: 0x14CF5E1 VA: 0x14CF4E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x14CF540 Offset: 0x14CF641 VA: 0x14CF540
	public bool get_enableWordWrapping() { }

	// RVA: 0x14CF550 Offset: 0x14CF651 VA: 0x14CF550
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x14CF5C0 Offset: 0x14CF6C1 VA: 0x14CF5C0
	public float get_wordWrappingRatios() { }

	// RVA: 0x14CF5D0 Offset: 0x14CF6D1 VA: 0x14CF5D0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x14CF630 Offset: 0x14CF731 VA: 0x14CF630
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x14CF640 Offset: 0x14CF741 VA: 0x14CF640
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x14CF6A0 Offset: 0x14CF7A1 VA: 0x14CF6A0
	public bool get_isTextOverflowing() { }

	// RVA: 0x14CF6B0 Offset: 0x14CF7B1 VA: 0x14CF6B0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x14CF6C0 Offset: 0x14CF7C1 VA: 0x14CF6C0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x14CF6D0 Offset: 0x14CF7D1 VA: 0x14CF6D0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x14CFA50 Offset: 0x14CFB51 VA: 0x14CFA50
	public bool get_isTextTruncated() { }

	// RVA: 0x14CFA60 Offset: 0x14CFB61 VA: 0x14CFA60
	public bool get_enableKerning() { }

	// RVA: 0x14CFA70 Offset: 0x14CFB71 VA: 0x14CFA70
	public void set_enableKerning(bool value) { }

	// RVA: 0x14CFAE0 Offset: 0x14CFBE1 VA: 0x14CFAE0
	public bool get_extraPadding() { }

	// RVA: 0x14CFAF0 Offset: 0x14CFBF1 VA: 0x14CFAF0
	public void set_extraPadding(bool value) { }

	// RVA: 0x14CFB60 Offset: 0x14CFC61 VA: 0x14CFB60
	public bool get_richText() { }

	// RVA: 0x14CFB70 Offset: 0x14CFC71 VA: 0x14CFB70
	public void set_richText(bool value) { }

	// RVA: 0x14CFBE0 Offset: 0x14CFCE1 VA: 0x14CFBE0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x14CFBF0 Offset: 0x14CFCF1 VA: 0x14CFBF0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x14CFC60 Offset: 0x14CFD61 VA: 0x14CFC60
	public bool get_isOverlay() { }

	// RVA: 0x14CFC70 Offset: 0x14CFD71 VA: 0x14CFC70
	public void set_isOverlay(bool value) { }

	// RVA: 0x14CFCE0 Offset: 0x14CFDE1 VA: 0x14CFCE0
	public bool get_isOrthographic() { }

	// RVA: 0x14CFCF0 Offset: 0x14CFDF1 VA: 0x14CFCF0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x14CFD30 Offset: 0x14CFE31 VA: 0x14CFD30
	public bool get_enableCulling() { }

	// RVA: 0x14CFD40 Offset: 0x14CFE41 VA: 0x14CFD40
	public void set_enableCulling(bool value) { }

	// RVA: 0x14CFD90 Offset: 0x14CFE91 VA: 0x14CFD90
	public bool get_ignoreVisibility() { }

	// RVA: 0x14CFDA0 Offset: 0x14CFEA1 VA: 0x14CFDA0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x14CFDD0 Offset: 0x14CFED1 VA: 0x14CFDD0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x14CFDE0 Offset: 0x14CFEE1 VA: 0x14CFDE0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE10 Offset: 0x14CFF11 VA: 0x14CFE10
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x14CFE20 Offset: 0x14CFF21 VA: 0x14CFE20
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE50 Offset: 0x14CFF51 VA: 0x14CFE50
	public float get_mappingUvLineOffset() { }

	// RVA: 0x14CFE60 Offset: 0x14CFF61 VA: 0x14CFE60
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x14CFE90 Offset: 0x14CFF91 VA: 0x14CFE90
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x14CFEA0 Offset: 0x14CFFA1 VA: 0x14CFEA0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x14CFEC0 Offset: 0x14CFFC1 VA: 0x14CFEC0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x14CFED0 Offset: 0x14CFFD1 VA: 0x14CFED0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x14CFEF0 Offset: 0x14CFFF1 VA: 0x14CFEF0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x14CFF00 Offset: 0x14D0001 VA: 0x14CFF00
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x14CFF20 Offset: 0x14D0021 VA: 0x14CFF20
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x14CFF30 Offset: 0x14D0031 VA: 0x14CFF30
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x14CFF50 Offset: 0x14D0051 VA: 0x14CFF50
	public int get_firstVisibleCharacter() { }

	// RVA: 0x14CFF60 Offset: 0x14D0061 VA: 0x14CFF60
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x14CFF90 Offset: 0x14D0091 VA: 0x14CFF90
	public int get_maxVisibleCharacters() { }

	// RVA: 0x14CFFA0 Offset: 0x14D00A1 VA: 0x14CFFA0
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x14CFFD0 Offset: 0x14D00D1 VA: 0x14CFFD0
	public int get_maxVisibleWords() { }

	// RVA: 0x14CFFE0 Offset: 0x14D00E1 VA: 0x14CFFE0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x14D0010 Offset: 0x14D0111 VA: 0x14D0010
	public int get_maxVisibleLines() { }

	// RVA: 0x14D0020 Offset: 0x14D0121 VA: 0x14D0020
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x14D0050 Offset: 0x14D0151 VA: 0x14D0050
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x14D0060 Offset: 0x14D0161 VA: 0x14D0060
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x14D00A0 Offset: 0x14D01A1 VA: 0x14D00A0
	public int get_pageToDisplay() { }

	// RVA: 0x14D00B0 Offset: 0x14D01B1 VA: 0x14D00B0
	public void set_pageToDisplay(int value) { }

	// RVA: 0x14D00E0 Offset: 0x14D01E1 VA: 0x14D00E0 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x14D0100 Offset: 0x14D0201 VA: 0x14D0100 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x14D0230 Offset: 0x14D0331 VA: 0x14D0230
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x14D0240 Offset: 0x14D0341 VA: 0x14D0240
	public bool get_havePropertiesChanged() { }

	// RVA: 0x14CBB20 Offset: 0x14CBC21 VA: 0x14CBB20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x14D0250 Offset: 0x14D0351 VA: 0x14D0250
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x14D0260 Offset: 0x14D0361 VA: 0x14D0260
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x14CCE50 Offset: 0x14CCF51 VA: 0x14CCE50
	public Transform get_transform() { }

	// RVA: 0x14CCF00 Offset: 0x14CD001 VA: 0x14CCF00
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x140690 Offset: 0x140791 VA: 0x140690
	// RVA: 0x14D0270 Offset: 0x14D0371 VA: 0x14D0270 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406A0 Offset: 0x1407A1 VA: 0x1406A0
	// RVA: 0x14D0280 Offset: 0x14D0381 VA: 0x14D0280 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x14D0290 Offset: 0x14D0391 VA: 0x14D0290 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x14D02A0 Offset: 0x14D03A1 VA: 0x14D02A0
	public bool get_isVolumetricText() { }

	// RVA: 0x14D02B0 Offset: 0x14D03B1 VA: 0x14D02B0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x14D0340 Offset: 0x14D0441 VA: 0x14D0340
	public Bounds get_bounds() { }

	// RVA: 0x14D03F0 Offset: 0x14D04F1 VA: 0x14D03F0
	public Bounds get_textBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406B0 Offset: 0x1407B1 VA: 0x1406B0
	// RVA: 0x14D06D0 Offset: 0x14D07D1 VA: 0x14D06D0
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406C0 Offset: 0x1407C1 VA: 0x1406C0
	// RVA: 0x14D07C0 Offset: 0x14D08C1 VA: 0x14D07C0
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406D0 Offset: 0x1407D1 VA: 0x1406D0
	// RVA: 0x14D08B0 Offset: 0x14D09B1 VA: 0x14D08B0
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406E0 Offset: 0x1407E1 VA: 0x1406E0
	// RVA: 0x14D09A0 Offset: 0x14D0AA1 VA: 0x14D09A0
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406F0 Offset: 0x1407F1 VA: 0x1406F0
	// RVA: 0x14D0A90 Offset: 0x14D0B91 VA: 0x14D0A90 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140700 Offset: 0x140801 VA: 0x140700
	// RVA: 0x14D0B40 Offset: 0x14D0C41 VA: 0x14D0B40 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x14D0BF0 Offset: 0x14D0CF1 VA: 0x14D0BF0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x14D0D00 Offset: 0x14D0E01 VA: 0x14D0D00 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x14D0D10 Offset: 0x14D0E11 VA: 0x14D0D10 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x14D0D20 Offset: 0x14D0E21 VA: 0x14D0D20 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x14D0D30 Offset: 0x14D0E31 VA: 0x14D0D30 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x14D0D40 Offset: 0x14D0E41 VA: 0x14D0D40
	public float get_maxWidth() { }

	// RVA: 0x14D0D50 Offset: 0x14D0E51 VA: 0x14D0D50
	public float get_maxHeight() { }

	// RVA: 0x14D0D60 Offset: 0x14D0E61 VA: 0x14D0D60
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x14D0E10 Offset: 0x14D0F11 VA: 0x14D0E10 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x14D0FB0 Offset: 0x14D10B1 VA: 0x14D0FB0 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x14D1190 Offset: 0x14D1291 VA: 0x14D1190 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x14D11B0 Offset: 0x14D12B1 VA: 0x14D11B0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x14D11F0 Offset: 0x14D12F1 VA: 0x14D11F0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x14D1200 Offset: 0x14D1301 VA: 0x14D1200 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x14D1210 Offset: 0x14D1311 VA: 0x14D1210 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x14D1220 Offset: 0x14D1321 VA: 0x14D1220 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x14D1230 Offset: 0x14D1331 VA: 0x14D1230 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x14D1240 Offset: 0x14D1341 VA: 0x14D1240 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x14D1250 Offset: 0x14D1351 VA: 0x14D1250 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x14D1260 Offset: 0x14D1361 VA: 0x14D1260 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x14D1270 Offset: 0x14D1371 VA: 0x14D1270 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x14D1330 Offset: 0x14D1431 VA: 0x14D1330
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x14D1430 Offset: 0x14D1531 VA: 0x14D1430
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x14D1440 Offset: 0x14D1541 VA: 0x14D1440
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x14D1450 Offset: 0x14D1551 VA: 0x14D1450 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x14D1460 Offset: 0x14D1561 VA: 0x14D1460 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x14D1470 Offset: 0x14D1571 VA: 0x14D1470 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x14D1480 Offset: 0x14D1581 VA: 0x14D1480 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x14D1490 Offset: 0x14D1591 VA: 0x14D1490 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x14D14A0 Offset: 0x14D15A1 VA: 0x14D14A0 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x14D14B0 Offset: 0x14D15B1 VA: 0x14D14B0 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x14D15F0 Offset: 0x14D16F1 VA: 0x14D15F0 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x14D1710 Offset: 0x14D1811 VA: 0x14D1710 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x14D1720 Offset: 0x14D1821 VA: 0x14D1720 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x14D1730 Offset: 0x14D1831 VA: 0x14D1730
	internal void SetTextInternal(string text) { }

	// RVA: 0x14D1790 Offset: 0x14D1891 VA: 0x14D1790 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x14D17A0 Offset: 0x14D18A1 VA: 0x14D17A0 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x14D17B0 Offset: 0x14D18B1 VA: 0x14D17B0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x14D17C0 Offset: 0x14D18C1 VA: 0x14D17C0 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x14D17D0 Offset: 0x14D18D1 VA: 0x14D17D0 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x14D17E0 Offset: 0x14D18E1 VA: 0x14D17E0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D1880 Offset: 0x14D1981 VA: 0x14D1880 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D18E0 Offset: 0x14D19E1 VA: 0x14D18E0 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D18F0 Offset: 0x14D19F1 VA: 0x14D18F0 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D1900 Offset: 0x14D1A01 VA: 0x14D1900
	protected void ParseInputText() { }

	// RVA: 0x14D2CD0 Offset: 0x14D2DD1 VA: 0x14D2CD0
	public void SetText(string text, bool syncTextInputBox = True) { }

	// RVA: 0x14D2CE0 Offset: 0x14D2DE1 VA: 0x14D2CE0
	public void SetText(string text, float arg0) { }

	// RVA: 0x14D2FF0 Offset: 0x14D30F1 VA: 0x14D2FF0
	public void SetText(string text, float arg0, float arg1) { }

	// RVA: 0x14D3010 Offset: 0x14D3111 VA: 0x14D3010
	public void SetText(string text, float arg0, float arg1, float arg2) { }

	// RVA: 0x14D3030 Offset: 0x14D3131 VA: 0x14D3030
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x14D3050 Offset: 0x14D3151 VA: 0x14D3050
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x14D3060 Offset: 0x14D3161 VA: 0x14D3060
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x14D3070 Offset: 0x14D3171 VA: 0x14D3070
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x14D2D00 Offset: 0x14D2E01 VA: 0x14D2D00
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x14D33D0 Offset: 0x14D34D1 VA: 0x14D33D0
	public void SetText(StringBuilder text) { }

	// RVA: 0x14D3DD0 Offset: 0x14D3ED1 VA: 0x14D3DD0
	public void SetText(char[] text) { }

	// RVA: 0x14D4460 Offset: 0x14D4561 VA: 0x14D4460
	public void SetText(char[] text, int start, int length) { }

	// RVA: 0x14D3DE0 Offset: 0x14D3EE1 VA: 0x14D3DE0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x14D4470 Offset: 0x14D4571 VA: 0x14D4470
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x14D5E70 Offset: 0x14D5F71 VA: 0x14D5E70
	public void SetCharArray(int[] sourceText, int start, int length) { }

	// RVA: 0x14D2640 Offset: 0x14D2741 VA: 0x14D2640
	protected int CharArrayToInternalParsingBuffer(char[] sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D1A30 Offset: 0x14D1B31 VA: 0x14D1A30
	protected int StringToInternalParsingBuffer(string sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D3430 Offset: 0x14D3531 VA: 0x14D3430
	protected int StringBuilderToInternalParsingBuffer(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D7240 Offset: 0x14D7341 VA: 0x14D7240
	private bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D65F0 Offset: 0x14D66F1 VA: 0x14D65F0
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D50E0 Offset: 0x14D51E1 VA: 0x14D50E0
	private bool ReplaceOpeningStyleTag(ref char[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7E90 Offset: 0x14D7F91 VA: 0x14D7E90
	private bool ReplaceOpeningStyleTag(ref StringBuilder sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D76F0 Offset: 0x14D77F1 VA: 0x14D76F0
	private bool ReplaceClosingStyleTag(ref string sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D6AA0 Offset: 0x14D6BA1 VA: 0x14D6AA0
	private bool ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5590 Offset: 0x14D5691 VA: 0x14D5590
	private bool ReplaceClosingStyleTag(ref char[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D8330 Offset: 0x14D8431 VA: 0x14D8330
	private bool ReplaceClosingStyleTag(ref StringBuilder sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14CE670 Offset: 0x14CE771 VA: 0x14CE670
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x14D4B50 Offset: 0x14D4C51 VA: 0x14D4B50
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5A10 Offset: 0x14D5B11 VA: 0x14D5A10
	private bool InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7130 Offset: 0x14D7231 VA: 0x14D7130
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0x14D4FB0 Offset: 0x14D50B1 VA: 0x14D4FB0
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0x14D64C0 Offset: 0x14D65C1 VA: 0x14D64C0
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0x14D7D80 Offset: 0x14D7E81 VA: 0x14D7D80
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0x14D87B0 Offset: 0x14D88B1 VA: 0x14D87B0
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0x14D8BE0 Offset: 0x14D8CE1 VA: 0x14D8BE0
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8AE0 Offset: 0x14D8BE1 VA: 0x14D8AE0
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8CE0 Offset: 0x14D8DE1 VA: 0x14D8CE0
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1B90 Offset: 0x23E1C91 VA: 0x23E1B90
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1CC0 Offset: 0x23E1DC1 VA: 0x23E1CC0
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1C30 Offset: 0x23E1D31 VA: 0x23E1C30
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1D60 Offset: 0x23E1E61 VA: 0x23E1D60
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x14D3080 Offset: 0x14D3181 VA: 0x14D3080
	private void AddFloatToCharArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x14D8E00 Offset: 0x14D8F01 VA: 0x14D8E00
	private void AddIntegerToCharArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x14D8F60 Offset: 0x14D9061 VA: 0x14D8F60 Slot: 114
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x14D8F70 Offset: 0x14D9071 VA: 0x14D8F70 Slot: 115
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x14D8F80 Offset: 0x14D9081 VA: 0x14D8F80
	public Vector2 GetPreferredValues() { }

	// RVA: 0x14D9000 Offset: 0x14D9101 VA: 0x14D9000
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x14D9290 Offset: 0x14D9391 VA: 0x14D9290
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x14D9440 Offset: 0x14D9541 VA: 0x14D9440
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x14D0E40 Offset: 0x14D0F41 VA: 0x14D0E40
	protected float GetPreferredWidth() { }

	// RVA: 0x14D9170 Offset: 0x14D9271 VA: 0x14D9170
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x14D0FE0 Offset: 0x14D10E1 VA: 0x14D0FE0
	protected float GetPreferredHeight() { }

	// RVA: 0x14D91E0 Offset: 0x14D92E1 VA: 0x14D91E0
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x14D95C0 Offset: 0x14D96C1 VA: 0x14D95C0
	public Vector2 GetRenderedValues() { }

	// RVA: 0x14D9690 Offset: 0x14D9791 VA: 0x14D9690
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11A0 Offset: 0x14D12A1 VA: 0x14D11A0
	private float GetRenderedWidth() { }

	// RVA: 0x14D9A90 Offset: 0x14D9B91 VA: 0x14D9A90
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11D0 Offset: 0x14D12D1 VA: 0x14D11D0
	private float GetRenderedHeight() { }

	// RVA: 0x14D9AA0 Offset: 0x14D9BA1 VA: 0x14D9AA0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x14D9AC0 Offset: 0x14D9BC1 VA: 0x14D9AC0 Slot: 116
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x14E17A0 Offset: 0x14E18A1 VA: 0x14E17A0 Slot: 117
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x14E17B0 Offset: 0x14E18B1 VA: 0x14E17B0 Slot: 118
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x14D0410 Offset: 0x14D0511 VA: 0x14D0410
	protected Bounds GetTextBounds() { }

	// RVA: 0x14D9770 Offset: 0x14D9871 VA: 0x14D9770
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x14E17C0 Offset: 0x14E18C1 VA: 0x14E17C0
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x14E1BE0 Offset: 0x14E1CE1 VA: 0x14E1BE0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x14E1E70 Offset: 0x14E1F71 VA: 0x14E1E70 Slot: 119
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x14E1E80 Offset: 0x14E1F81 VA: 0x14E1E80 Slot: 120
	public virtual void ComputeMarginSize() { }

	// RVA: 0x14E1E90 Offset: 0x14E1F91 VA: 0x14E1E90
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x14E1390 Offset: 0x14E1491 VA: 0x14E1390
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x14E0EE0 Offset: 0x14E0FE1 VA: 0x14E0EE0
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x14E2580 Offset: 0x14E2681 VA: 0x14E2580 Slot: 121
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x14E30E0 Offset: 0x14E31E1 VA: 0x14E30E0 Slot: 122
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x14E38B0 Offset: 0x14E39B1 VA: 0x14E38B0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E4000 Offset: 0x14E4101 VA: 0x14E4000 Slot: 124
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x14E4F20 Offset: 0x14E5021 VA: 0x14E4F20 Slot: 125
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E5670 Offset: 0x14E5771 VA: 0x14E5670 Slot: 126
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x14E68A0 Offset: 0x14E69A1 VA: 0x14E68A0 Slot: 127
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x14E6E20 Offset: 0x14E6F21 VA: 0x14E6E20
	protected void LoadDefaultSettings() { }

	// RVA: 0x14E71E0 Offset: 0x14E72E1 VA: 0x14E71E0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7210 Offset: 0x14E7311 VA: 0x14E7210
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E6700 Offset: 0x14E6801 VA: 0x14E6700
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7490 Offset: 0x14E7591 VA: 0x14E7490
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x14E7520 Offset: 0x14E7621 VA: 0x14E7520
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x14E75B0 Offset: 0x14E76B1 VA: 0x14E75B0
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x14E79C0 Offset: 0x14E7AC1 VA: 0x14E79C0 Slot: 128
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x14E79D0 Offset: 0x14E7AD1 VA: 0x14E79D0 Slot: 129
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x14E79E0 Offset: 0x14E7AE1 VA: 0x14E79E0 Slot: 130
	public virtual void ClearMesh() { }

	// RVA: 0x14E79F0 Offset: 0x14E7AF1 VA: 0x14E79F0 Slot: 131
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x14E7A00 Offset: 0x14E7B01 VA: 0x14E7A00 Slot: 132
	public virtual string GetParsedText() { }

	// RVA: 0x14CF940 Offset: 0x14CFA41 VA: 0x14CF940
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x14CF800 Offset: 0x14CF901 VA: 0x14CF800
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x14E6860 Offset: 0x14E6961 VA: 0x14E6860
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x14E7B20 Offset: 0x14E7C21 VA: 0x14E7B20
	protected float PackUV(float x, float y) { }

	// RVA: 0x14E7B60 Offset: 0x14E7C61 VA: 0x14E7B60 Slot: 133
	internal virtual void InternalUpdate() { }

	// RVA: 0x14E7B70 Offset: 0x14E7C71 VA: 0x14E7B70
	protected int HexToInt(char hex) { }

	// RVA: 0x14D7070 Offset: 0x14D7171 VA: 0x14D7070
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x14D88D0 Offset: 0x14D89D1 VA: 0x14D88D0
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x14D7CC0 Offset: 0x14D7DC1 VA: 0x14D7CC0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x14D6F20 Offset: 0x14D7021 VA: 0x14D6F20
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x14D8990 Offset: 0x14D8A91 VA: 0x14D8990
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x14D7B70 Offset: 0x14D7C71 VA: 0x14D7B70
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x14E7BA0 Offset: 0x14E7CA1 VA: 0x14E7BA0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x14E8000 Offset: 0x14E8101 VA: 0x14E8000
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x14E8290 Offset: 0x14E8391 VA: 0x14E8290
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x14E8540 Offset: 0x14E8641 VA: 0x14E8540
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x14E8350 Offset: 0x14E8451 VA: 0x14E8350
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x14DC210 Offset: 0x14DC311 VA: 0x14DC210
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x14E8570 Offset: 0x14E8671 VA: 0x14E8570
	protected void .ctor() { }

	// RVA: 0x14E9110 Offset: 0x14E9211 VA: 0x14E9110
	private static void .cctor() { }
}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 5864
{
	// Fields
	[SerializeField] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	[TextAreaAttribute] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	protected string m_text; // 0xC0
	[SerializeField] // RVA: 0x13FE90 Offset: 0x13FF91 VA: 0x13FE90
	protected ITextPreprocessor m_TextPreprocessor; // 0xC8
	[SerializeField] // RVA: 0x13FEA0 Offset: 0x13FFA1 VA: 0x13FEA0
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x13FEB0 Offset: 0x13FFB1 VA: 0x13FEB0
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x13FEC0 Offset: 0x13FFC1 VA: 0x13FEC0
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x168
	[SerializeField] // RVA: 0x13FED0 Offset: 0x13FFD1 VA: 0x13FED0
	protected Material[] m_fontSharedMaterials; // 0x170
	[SerializeField] // RVA: 0x13FEE0 Offset: 0x13FFE1 VA: 0x13FEE0
	protected Material m_fontMaterial; // 0x178
	[SerializeField] // RVA: 0x13FEF0 Offset: 0x13FFF1 VA: 0x13FEF0
	protected Material[] m_fontMaterials; // 0x180
	protected bool m_isMaterialDirty; // 0x188
	[SerializeField] // RVA: 0x13FF00 Offset: 0x140001 VA: 0x13FF00
	protected Color32 m_fontColor32; // 0x18C
	[SerializeField] // RVA: 0x13FF10 Offset: 0x140011 VA: 0x13FF10
	protected Color m_fontColor; // 0x190
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x1A0
	protected Color32 m_strikethroughColor; // 0x1A4
	[SerializeField] // RVA: 0x13FF20 Offset: 0x140021 VA: 0x13FF20
	protected bool m_enableVertexGradient; // 0x1A8
	[SerializeField] // RVA: 0x13FF30 Offset: 0x140031 VA: 0x13FF30
	protected ColorMode m_colorMode; // 0x1AC
	[SerializeField] // RVA: 0x13FF40 Offset: 0x140041 VA: 0x13FF40
	protected VertexGradient m_fontColorGradient; // 0x1B0
	[SerializeField] // RVA: 0x13FF50 Offset: 0x140051 VA: 0x13FF50
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x13FF60 Offset: 0x140061 VA: 0x13FF60
	protected TMP_SpriteAsset m_spriteAsset; // 0x1F8
	[SerializeField] // RVA: 0x13FF70 Offset: 0x140071 VA: 0x13FF70
	protected bool m_tintAllSprites; // 0x200
	protected bool m_tintSprite; // 0x201
	protected Color32 m_spriteColor; // 0x204
	[SerializeField] // RVA: 0x13FF80 Offset: 0x140081 VA: 0x13FF80
	protected TMP_StyleSheet m_StyleSheet; // 0x208
	internal TMP_Style m_TextStyle; // 0x210
	[SerializeField] // RVA: 0x13FF90 Offset: 0x140091 VA: 0x13FF90
	protected int m_TextStyleHashCode; // 0x218
	[SerializeField] // RVA: 0x13FFA0 Offset: 0x1400A1 VA: 0x13FFA0
	protected bool m_overrideHtmlColors; // 0x21C
	[SerializeField] // RVA: 0x13FFB0 Offset: 0x1400B1 VA: 0x13FFB0
	protected Color32 m_faceColor; // 0x220
	protected Color32 m_outlineColor; // 0x224
	protected float m_outlineWidth; // 0x228
	[SerializeField] // RVA: 0x13FFC0 Offset: 0x1400C1 VA: 0x13FFC0
	protected float m_fontSize; // 0x22C
	protected float m_currentFontSize; // 0x230
	[SerializeField] // RVA: 0x13FFD0 Offset: 0x1400D1 VA: 0x13FFD0
	protected float m_fontSizeBase; // 0x234
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x238
	[SerializeField] // RVA: 0x13FFE0 Offset: 0x1400E1 VA: 0x13FFE0
	protected FontWeight m_fontWeight; // 0x258
	protected FontWeight m_FontWeightInternal; // 0x25C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x260
	[SerializeField] // RVA: 0x13FFF0 Offset: 0x1400F1 VA: 0x13FFF0
	protected bool m_enableAutoSizing; // 0x280
	protected float m_maxFontSize; // 0x284
	protected float m_minFontSize; // 0x288
	protected int m_AutoSizeIterationCount; // 0x28C
	protected int m_AutoSizeMaxIterationCount; // 0x290
	protected bool m_IsAutoSizePointSizeSet; // 0x294
	[SerializeField] // RVA: 0x140000 Offset: 0x140101 VA: 0x140000
	protected float m_fontSizeMin; // 0x298
	[SerializeField] // RVA: 0x140010 Offset: 0x140111 VA: 0x140010
	protected float m_fontSizeMax; // 0x29C
	[SerializeField] // RVA: 0x140020 Offset: 0x140121 VA: 0x140020
	protected FontStyles m_fontStyle; // 0x2A0
	protected FontStyles m_FontStyleInternal; // 0x2A4
	protected TMP_FontStyleStack m_fontStyleStack; // 0x2A8
	protected bool m_isUsingBold; // 0x2B2
	[SerializeField] // RVA: 0x140030 Offset: 0x140131 VA: 0x140030
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x2B4
	[SerializeField] // RVA: 0x140040 Offset: 0x140141 VA: 0x140040
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x2B8
	[SerializeField] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	[FormerlySerializedAsAttribute] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	protected TextAlignmentOptions m_textAlignment; // 0x2BC
	protected HorizontalAlignmentOptions m_lineJustification; // 0x2C0
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2C8
	protected Vector3[] m_textContainerLocalCorners; // 0x2E8
	[SerializeField] // RVA: 0x1400A0 Offset: 0x1401A1 VA: 0x1400A0
	protected float m_characterSpacing; // 0x2F0
	protected float m_cSpacing; // 0x2F4
	protected float m_monoSpacing; // 0x2F8
	[SerializeField] // RVA: 0x1400B0 Offset: 0x1401B1 VA: 0x1400B0
	protected float m_wordSpacing; // 0x2FC
	[SerializeField] // RVA: 0x1400C0 Offset: 0x1401C1 VA: 0x1400C0
	protected float m_lineSpacing; // 0x300
	protected float m_lineSpacingDelta; // 0x304
	protected float m_lineHeight; // 0x308
	protected bool m_IsDrivenLineSpacing; // 0x30C
	[SerializeField] // RVA: 0x1400D0 Offset: 0x1401D1 VA: 0x1400D0
	protected float m_lineSpacingMax; // 0x310
	[SerializeField] // RVA: 0x1400E0 Offset: 0x1401E1 VA: 0x1400E0
	protected float m_paragraphSpacing; // 0x314
	[SerializeField] // RVA: 0x1400F0 Offset: 0x1401F1 VA: 0x1400F0
	protected float m_charWidthMaxAdj; // 0x318
	protected float m_charWidthAdjDelta; // 0x31C
	[SerializeField] // RVA: 0x140100 Offset: 0x140201 VA: 0x140100
	protected bool m_enableWordWrapping; // 0x320
	protected bool m_isCharacterWrappingEnabled; // 0x321
	protected bool m_isNonBreakingSpace; // 0x322
	protected bool m_isIgnoringAlignment; // 0x323
	[SerializeField] // RVA: 0x140110 Offset: 0x140211 VA: 0x140110
	protected float m_wordWrappingRatios; // 0x324
	[SerializeField] // RVA: 0x140120 Offset: 0x140221 VA: 0x140120
	protected TextOverflowModes m_overflowMode; // 0x328
	protected int m_firstOverflowCharacterIndex; // 0x32C
	[SerializeField] // RVA: 0x140130 Offset: 0x140231 VA: 0x140130
	protected TMP_Text m_linkedTextComponent; // 0x330
	[SerializeField] // RVA: 0x140140 Offset: 0x140241 VA: 0x140140
	internal TMP_Text parentLinkedComponent; // 0x338
	protected bool m_isTextTruncated; // 0x340
	[SerializeField] // RVA: 0x140150 Offset: 0x140251 VA: 0x140150
	protected bool m_enableKerning; // 0x341
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x344
	[SerializeField] // RVA: 0x140160 Offset: 0x140261 VA: 0x140160
	protected bool m_enableExtraPadding; // 0x348
	[SerializeField] // RVA: 0x140170 Offset: 0x140271 VA: 0x140170
	protected bool checkPaddingRequired; // 0x349
	[SerializeField] // RVA: 0x140180 Offset: 0x140281 VA: 0x140180
	protected bool m_isRichText; // 0x34A
	[SerializeField] // RVA: 0x140190 Offset: 0x140291 VA: 0x140190
	protected bool m_parseCtrlCharacters; // 0x34B
	protected bool m_isOverlay; // 0x34C
	[SerializeField] // RVA: 0x1401A0 Offset: 0x1402A1 VA: 0x1401A0
	protected bool m_isOrthographic; // 0x34D
	[SerializeField] // RVA: 0x1401B0 Offset: 0x1402B1 VA: 0x1401B0
	protected bool m_isCullingEnabled; // 0x34E
	protected bool m_isMaskingEnabled; // 0x34F
	protected bool isMaskUpdateRequired; // 0x350
	protected bool m_ignoreCulling; // 0x351
	[SerializeField] // RVA: 0x1401C0 Offset: 0x1402C1 VA: 0x1401C0
	protected TextureMappingOptions m_horizontalMapping; // 0x354
	[SerializeField] // RVA: 0x1401D0 Offset: 0x1402D1 VA: 0x1401D0
	protected TextureMappingOptions m_verticalMapping; // 0x358
	[SerializeField] // RVA: 0x1401E0 Offset: 0x1402E1 VA: 0x1401E0
	protected float m_uvLineOffset; // 0x35C
	protected TextRenderFlags m_renderMode; // 0x360
	[SerializeField] // RVA: 0x1401F0 Offset: 0x1402F1 VA: 0x1401F0
	protected VertexSortingOrder m_geometrySortingOrder; // 0x364
	[SerializeField] // RVA: 0x140200 Offset: 0x140301 VA: 0x140200
	protected bool m_IsTextObjectScaleStatic; // 0x368
	[SerializeField] // RVA: 0x140210 Offset: 0x140311 VA: 0x140210
	protected bool m_VertexBufferAutoSizeReduction; // 0x369
	protected int m_firstVisibleCharacter; // 0x36C
	protected int m_maxVisibleCharacters; // 0x370
	protected int m_maxVisibleWords; // 0x374
	protected int m_maxVisibleLines; // 0x378
	[SerializeField] // RVA: 0x140220 Offset: 0x140321 VA: 0x140220
	protected bool m_useMaxVisibleDescender; // 0x37C
	[SerializeField] // RVA: 0x140230 Offset: 0x140331 VA: 0x140230
	protected int m_pageToDisplay; // 0x380
	protected bool m_isNewPage; // 0x384
	[SerializeField] // RVA: 0x140240 Offset: 0x140341 VA: 0x140240
	protected Vector4 m_margin; // 0x388
	protected float m_marginLeft; // 0x398
	protected float m_marginRight; // 0x39C
	protected float m_marginWidth; // 0x3A0
	protected float m_marginHeight; // 0x3A4
	protected float m_width; // 0x3A8
	protected TMP_TextInfo m_textInfo; // 0x3B0
	protected bool m_havePropertiesChanged; // 0x3B8
	[SerializeField] // RVA: 0x140250 Offset: 0x140351 VA: 0x140250
	protected bool m_isUsingLegacyAnimationComponent; // 0x3B9
	protected Transform m_transform; // 0x3C0
	protected RectTransform m_rectTransform; // 0x3C8
	protected Vector2 m_PreviousRectTransformSize; // 0x3D0
	protected Vector2 m_PreviousPivotPosition; // 0x3D8
	[CompilerGeneratedAttribute] // RVA: 0x140260 Offset: 0x140361 VA: 0x140260
	private bool <autoSizeTextContainer>k__BackingField; // 0x3E0
	protected bool m_autoSizeTextContainer; // 0x3E1
	protected Mesh m_mesh; // 0x3E8
	[SerializeField] // RVA: 0x140270 Offset: 0x140371 VA: 0x140270
	protected bool m_isVolumetricText; // 0x3F0
	[CompilerGeneratedAttribute] // RVA: 0x140280 Offset: 0x140381 VA: 0x140280
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x140290 Offset: 0x140391 VA: 0x140290
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1402A0 Offset: 0x1403A1 VA: 0x1402A0
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3F8
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x400
	protected float m_flexibleHeight; // 0x408
	protected float m_flexibleWidth; // 0x40C
	protected float m_minWidth; // 0x410
	protected float m_minHeight; // 0x414
	protected float m_maxWidth; // 0x418
	protected float m_maxHeight; // 0x41C
	protected LayoutElement m_LayoutElement; // 0x420
	protected float m_preferredWidth; // 0x428
	protected float m_renderedWidth; // 0x42C
	protected bool m_isPreferredWidthDirty; // 0x430
	protected float m_preferredHeight; // 0x434
	protected float m_renderedHeight; // 0x438
	protected bool m_isPreferredHeightDirty; // 0x43C
	protected bool m_isCalculatingPreferredValues; // 0x43D
	protected int m_layoutPriority; // 0x440
	protected bool m_isLayoutDirty; // 0x444
	protected bool m_isAwake; // 0x445
	internal bool m_isWaitingOnResourceLoad; // 0x446
	internal bool m_isInputParsingRequired; // 0x447
	internal TMP_Text.TextInputSources m_inputSource; // 0x448
	protected float m_fontScale; // 0x44C
	protected float m_fontScaleMultiplier; // 0x450
	protected char[] m_htmlTag; // 0x458
	protected RichTextTagAttribute[] m_xmlAttribute; // 0x460
	protected float[] m_attributeParameterValues; // 0x468
	protected float tag_LineIndent; // 0x470
	protected float tag_Indent; // 0x474
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x478
	protected bool tag_NoParsing; // 0x498
	protected bool m_isParsingText; // 0x499
	protected Matrix4x4 m_FXMatrix; // 0x49C
	protected bool m_isFXMatrixSet; // 0x4DC
	protected TMP_Text.UnicodeChar[] m_InternalParsingBuffer; // 0x4E0
	protected int m_InternalParsingBufferSize; // 0x4E8
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x4F0
	protected char[] m_input_CharArray; // 0x4F8
	private int m_charArray_Length; // 0x500
	protected int m_totalCharacterCount; // 0x504
	protected WordWrapState m_SavedWordWrapState; // 0x508
	protected WordWrapState m_SavedLineState; // 0x880
	protected WordWrapState m_SavedEllipsisState; // 0xBF8
	protected WordWrapState m_SavedLastValidState; // 0xF70
	protected WordWrapState m_SavedSoftLineBreakState; // 0x12E8
	internal TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1660
	protected int m_characterCount; // 0x19F8
	protected int m_firstCharacterOfLine; // 0x19FC
	protected int m_firstVisibleCharacterOfLine; // 0x1A00
	protected int m_lastCharacterOfLine; // 0x1A04
	protected int m_lastVisibleCharacterOfLine; // 0x1A08
	protected int m_lineNumber; // 0x1A0C
	protected int m_lineVisibleCharacterCount; // 0x1A10
	protected int m_pageNumber; // 0x1A14
	protected float m_PageAscender; // 0x1A18
	protected float m_maxTextAscender; // 0x1A1C
	protected float m_maxCapHeight; // 0x1A20
	protected float m_ElementAscender; // 0x1A24
	protected float m_ElementDescender; // 0x1A28
	protected float m_maxLineAscender; // 0x1A2C
	protected float m_maxLineDescender; // 0x1A30
	protected float m_startOfLineAscender; // 0x1A34
	protected float m_startOfLineDescender; // 0x1A38
	protected float m_lineOffset; // 0x1A3C
	protected Extents m_meshExtents; // 0x1A40
	protected Color32 m_htmlColor; // 0x1A50
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x1A58
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x1A78
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x1A98
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x1AB8
	protected TMP_ColorGradient m_colorGradientPreset; // 0x1AE8
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x1AF0
	protected bool m_colorGradientPresetIsTinted; // 0x1B18
	protected float m_tabSpacing; // 0x1B1C
	protected float m_spacing; // 0x1B20
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x1B28
	protected int m_TextStyleStackDepth; // 0x1B30
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x1B38
	protected int m_ItalicAngle; // 0x1B58
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x1B60
	protected float m_padding; // 0x1B80
	protected float m_baselineOffset; // 0x1B84
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x1B88
	protected float m_xAdvance; // 0x1BA8
	protected TMP_TextElementType m_textElementType; // 0x1BAC
	protected TMP_TextElement m_cached_TextElement; // 0x1BB0
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x1BB8
	protected TMP_Text.SpecialCharacter m_Underline; // 0x1BD8
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x1BF8
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x1C00
	protected int m_spriteCount; // 0x1C08
	protected int m_spriteIndex; // 0x1C0C
	protected int m_spriteAnimationID; // 0x1C10
	protected bool m_ignoreActiveState; // 0x1C14
	private readonly Decimal[] k_Power; // 0x1C18
	protected static Vector2 k_LargePositiveVector2; // 0x18
	protected static Vector2 k_LargeNegativeVector2; // 0x20
	protected static float k_LargePositiveFloat; // 0x28
	protected static float k_LargeNegativeFloat; // 0x2C
	protected static int k_LargePositiveInt; // 0x30
	protected static int k_LargeNegativeInt; // 0x34

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public float fontScale { get; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x14CDCA0 Offset: 0x14CDDA1 VA: 0x14CDCA0 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x14CDCB0 Offset: 0x14CDDB1 VA: 0x14CDCB0 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x14CDD60 Offset: 0x14CDE61 VA: 0x14CDD60
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x14CDD70 Offset: 0x14CDE71 VA: 0x14CDD70
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x14CDD80 Offset: 0x14CDE81 VA: 0x14CDD80
	public bool get_isRightToLeftText() { }

	// RVA: 0x14CDD90 Offset: 0x14CDE91 VA: 0x14CDD90
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x14CDE00 Offset: 0x14CDF01 VA: 0x14CDE00
	public TMP_FontAsset get_font() { }

	// RVA: 0x14CDE10 Offset: 0x14CDF11 VA: 0x14CDE10
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x14CDF00 Offset: 0x14CE001 VA: 0x14CDF00 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x14CDF10 Offset: 0x14CE011 VA: 0x14CDF10 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x14CDFF0 Offset: 0x14CE0F1 VA: 0x14CDFF0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x14CE000 Offset: 0x14CE101 VA: 0x14CE000 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x14CE060 Offset: 0x14CE161 VA: 0x14CE060
	public Material get_fontMaterial() { }

	// RVA: 0x14CE080 Offset: 0x14CE181 VA: 0x14CE080
	public void set_fontMaterial(Material value) { }

	// RVA: 0x14CE1A0 Offset: 0x14CE2A1 VA: 0x14CE1A0 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x14CE1C0 Offset: 0x14CE2C1 VA: 0x14CE1C0 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x14CE220 Offset: 0x14CE321 VA: 0x14CE220 Slot: 22
	public override Color get_color() { }

	// RVA: 0x14CE240 Offset: 0x14CE341 VA: 0x14CE240 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x14CE2F0 Offset: 0x14CE3F1 VA: 0x14CE2F0
	public float get_alpha() { }

	// RVA: 0x14CE300 Offset: 0x14CE401 VA: 0x14CE300
	public void set_alpha(float value) { }

	// RVA: 0x14CE330 Offset: 0x14CE431 VA: 0x14CE330
	public bool get_enableVertexGradient() { }

	// RVA: 0x14CE340 Offset: 0x14CE441 VA: 0x14CE340
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x14CE380 Offset: 0x14CE481 VA: 0x14CE380
	public VertexGradient get_colorGradient() { }

	// RVA: 0x14CE3B0 Offset: 0x14CE4B1 VA: 0x14CE3B0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x14CE3F0 Offset: 0x14CE4F1 VA: 0x14CE3F0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x14CE400 Offset: 0x14CE501 VA: 0x14CE400
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x14CE440 Offset: 0x14CE541 VA: 0x14CE440
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x14CE450 Offset: 0x14CE551 VA: 0x14CE450
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x14CE4B0 Offset: 0x14CE5B1 VA: 0x14CE4B0
	public bool get_tintAllSprites() { }

	// RVA: 0x14CE4C0 Offset: 0x14CE5C1 VA: 0x14CE4C0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x14CE500 Offset: 0x14CE601 VA: 0x14CE500
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x14CE510 Offset: 0x14CE611 VA: 0x14CE510
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x14CE570 Offset: 0x14CE671 VA: 0x14CE570
	public TMP_Style get_textStyle() { }

	// RVA: 0x14CE830 Offset: 0x14CE931 VA: 0x14CE830
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x14CE8A0 Offset: 0x14CE9A1 VA: 0x14CE8A0
	public bool get_overrideColorTags() { }

	// RVA: 0x14CE8B0 Offset: 0x14CE9B1 VA: 0x14CE8B0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x14CE8F0 Offset: 0x14CE9F1 VA: 0x14CE8F0
	public Color32 get_faceColor() { }

	// RVA: 0x14CE9E0 Offset: 0x14CEAE1 VA: 0x14CE9E0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x14CEA80 Offset: 0x14CEB81 VA: 0x14CEA80
	public Color32 get_outlineColor() { }

	// RVA: 0x14CEB70 Offset: 0x14CEC71 VA: 0x14CEB70
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x14CEC00 Offset: 0x14CED01 VA: 0x14CEC00
	public float get_outlineWidth() { }

	// RVA: 0x14CECE0 Offset: 0x14CEDE1 VA: 0x14CECE0
	public void set_outlineWidth(float value) { }

	// RVA: 0x14CED60 Offset: 0x14CEE61 VA: 0x14CED60
	public float get_fontSize() { }

	// RVA: 0x14CED70 Offset: 0x14CEE71 VA: 0x14CED70
	public void set_fontSize(float value) { }

	// RVA: 0x14CEDE0 Offset: 0x14CEEE1 VA: 0x14CEDE0
	public float get_fontScale() { }

	// RVA: 0x14CEDF0 Offset: 0x14CEEF1 VA: 0x14CEDF0
	public FontWeight get_fontWeight() { }

	// RVA: 0x14CEE00 Offset: 0x14CEF01 VA: 0x14CEE00
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x14CEE60 Offset: 0x14CEF61 VA: 0x14CEE60
	public float get_pixelsPerUnit() { }

	// RVA: 0x14CF010 Offset: 0x14CF111 VA: 0x14CF010
	public bool get_enableAutoSizing() { }

	// RVA: 0x14CF020 Offset: 0x14CF121 VA: 0x14CF020
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x14CF080 Offset: 0x14CF181 VA: 0x14CF080
	public float get_fontSizeMin() { }

	// RVA: 0x14CF090 Offset: 0x14CF191 VA: 0x14CF090
	public void set_fontSizeMin(float value) { }

	// RVA: 0x14CF0E0 Offset: 0x14CF1E1 VA: 0x14CF0E0
	public float get_fontSizeMax() { }

	// RVA: 0x14CF0F0 Offset: 0x14CF1F1 VA: 0x14CF0F0
	public void set_fontSizeMax(float value) { }

	// RVA: 0x14CF140 Offset: 0x14CF241 VA: 0x14CF140
	public FontStyles get_fontStyle() { }

	// RVA: 0x14CF150 Offset: 0x14CF251 VA: 0x14CF150
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x14CF1B0 Offset: 0x14CF2B1 VA: 0x14CF1B0
	public bool get_isUsingBold() { }

	// RVA: 0x14CF1C0 Offset: 0x14CF2C1 VA: 0x14CF1C0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x14CF1D0 Offset: 0x14CF2D1 VA: 0x14CF1D0
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x14CF200 Offset: 0x14CF301 VA: 0x14CF200
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x14CF210 Offset: 0x14CF311 VA: 0x14CF210
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x14CF240 Offset: 0x14CF341 VA: 0x14CF240
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x14CF250 Offset: 0x14CF351 VA: 0x14CF250
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x14CF2A0 Offset: 0x14CF3A1 VA: 0x14CF2A0
	public float get_characterSpacing() { }

	// RVA: 0x14CF2B0 Offset: 0x14CF3B1 VA: 0x14CF2B0
	public void set_characterSpacing(float value) { }

	// RVA: 0x14CF310 Offset: 0x14CF411 VA: 0x14CF310
	public float get_wordSpacing() { }

	// RVA: 0x14CF320 Offset: 0x14CF421 VA: 0x14CF320
	public void set_wordSpacing(float value) { }

	// RVA: 0x14CF380 Offset: 0x14CF481 VA: 0x14CF380
	public float get_lineSpacing() { }

	// RVA: 0x14CF390 Offset: 0x14CF491 VA: 0x14CF390
	public void set_lineSpacing(float value) { }

	// RVA: 0x14CF3F0 Offset: 0x14CF4F1 VA: 0x14CF3F0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x14CF400 Offset: 0x14CF501 VA: 0x14CF400
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x14CF460 Offset: 0x14CF561 VA: 0x14CF460
	public float get_paragraphSpacing() { }

	// RVA: 0x14CF470 Offset: 0x14CF571 VA: 0x14CF470
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x14CF4D0 Offset: 0x14CF5D1 VA: 0x14CF4D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x14CF4E0 Offset: 0x14CF5E1 VA: 0x14CF4E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x14CF540 Offset: 0x14CF641 VA: 0x14CF540
	public bool get_enableWordWrapping() { }

	// RVA: 0x14CF550 Offset: 0x14CF651 VA: 0x14CF550
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x14CF5C0 Offset: 0x14CF6C1 VA: 0x14CF5C0
	public float get_wordWrappingRatios() { }

	// RVA: 0x14CF5D0 Offset: 0x14CF6D1 VA: 0x14CF5D0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x14CF630 Offset: 0x14CF731 VA: 0x14CF630
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x14CF640 Offset: 0x14CF741 VA: 0x14CF640
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x14CF6A0 Offset: 0x14CF7A1 VA: 0x14CF6A0
	public bool get_isTextOverflowing() { }

	// RVA: 0x14CF6B0 Offset: 0x14CF7B1 VA: 0x14CF6B0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x14CF6C0 Offset: 0x14CF7C1 VA: 0x14CF6C0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x14CF6D0 Offset: 0x14CF7D1 VA: 0x14CF6D0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x14CFA50 Offset: 0x14CFB51 VA: 0x14CFA50
	public bool get_isTextTruncated() { }

	// RVA: 0x14CFA60 Offset: 0x14CFB61 VA: 0x14CFA60
	public bool get_enableKerning() { }

	// RVA: 0x14CFA70 Offset: 0x14CFB71 VA: 0x14CFA70
	public void set_enableKerning(bool value) { }

	// RVA: 0x14CFAE0 Offset: 0x14CFBE1 VA: 0x14CFAE0
	public bool get_extraPadding() { }

	// RVA: 0x14CFAF0 Offset: 0x14CFBF1 VA: 0x14CFAF0
	public void set_extraPadding(bool value) { }

	// RVA: 0x14CFB60 Offset: 0x14CFC61 VA: 0x14CFB60
	public bool get_richText() { }

	// RVA: 0x14CFB70 Offset: 0x14CFC71 VA: 0x14CFB70
	public void set_richText(bool value) { }

	// RVA: 0x14CFBE0 Offset: 0x14CFCE1 VA: 0x14CFBE0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x14CFBF0 Offset: 0x14CFCF1 VA: 0x14CFBF0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x14CFC60 Offset: 0x14CFD61 VA: 0x14CFC60
	public bool get_isOverlay() { }

	// RVA: 0x14CFC70 Offset: 0x14CFD71 VA: 0x14CFC70
	public void set_isOverlay(bool value) { }

	// RVA: 0x14CFCE0 Offset: 0x14CFDE1 VA: 0x14CFCE0
	public bool get_isOrthographic() { }

	// RVA: 0x14CFCF0 Offset: 0x14CFDF1 VA: 0x14CFCF0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x14CFD30 Offset: 0x14CFE31 VA: 0x14CFD30
	public bool get_enableCulling() { }

	// RVA: 0x14CFD40 Offset: 0x14CFE41 VA: 0x14CFD40
	public void set_enableCulling(bool value) { }

	// RVA: 0x14CFD90 Offset: 0x14CFE91 VA: 0x14CFD90
	public bool get_ignoreVisibility() { }

	// RVA: 0x14CFDA0 Offset: 0x14CFEA1 VA: 0x14CFDA0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x14CFDD0 Offset: 0x14CFED1 VA: 0x14CFDD0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x14CFDE0 Offset: 0x14CFEE1 VA: 0x14CFDE0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE10 Offset: 0x14CFF11 VA: 0x14CFE10
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x14CFE20 Offset: 0x14CFF21 VA: 0x14CFE20
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE50 Offset: 0x14CFF51 VA: 0x14CFE50
	public float get_mappingUvLineOffset() { }

	// RVA: 0x14CFE60 Offset: 0x14CFF61 VA: 0x14CFE60
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x14CFE90 Offset: 0x14CFF91 VA: 0x14CFE90
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x14CFEA0 Offset: 0x14CFFA1 VA: 0x14CFEA0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x14CFEC0 Offset: 0x14CFFC1 VA: 0x14CFEC0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x14CFED0 Offset: 0x14CFFD1 VA: 0x14CFED0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x14CFEF0 Offset: 0x14CFFF1 VA: 0x14CFEF0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x14CFF00 Offset: 0x14D0001 VA: 0x14CFF00
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x14CFF20 Offset: 0x14D0021 VA: 0x14CFF20
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x14CFF30 Offset: 0x14D0031 VA: 0x14CFF30
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x14CFF50 Offset: 0x14D0051 VA: 0x14CFF50
	public int get_firstVisibleCharacter() { }

	// RVA: 0x14CFF60 Offset: 0x14D0061 VA: 0x14CFF60
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x14CFF90 Offset: 0x14D0091 VA: 0x14CFF90
	public int get_maxVisibleCharacters() { }

	// RVA: 0x14CFFA0 Offset: 0x14D00A1 VA: 0x14CFFA0
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x14CFFD0 Offset: 0x14D00D1 VA: 0x14CFFD0
	public int get_maxVisibleWords() { }

	// RVA: 0x14CFFE0 Offset: 0x14D00E1 VA: 0x14CFFE0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x14D0010 Offset: 0x14D0111 VA: 0x14D0010
	public int get_maxVisibleLines() { }

	// RVA: 0x14D0020 Offset: 0x14D0121 VA: 0x14D0020
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x14D0050 Offset: 0x14D0151 VA: 0x14D0050
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x14D0060 Offset: 0x14D0161 VA: 0x14D0060
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x14D00A0 Offset: 0x14D01A1 VA: 0x14D00A0
	public int get_pageToDisplay() { }

	// RVA: 0x14D00B0 Offset: 0x14D01B1 VA: 0x14D00B0
	public void set_pageToDisplay(int value) { }

	// RVA: 0x14D00E0 Offset: 0x14D01E1 VA: 0x14D00E0 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x14D0100 Offset: 0x14D0201 VA: 0x14D0100 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x14D0230 Offset: 0x14D0331 VA: 0x14D0230
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x14D0240 Offset: 0x14D0341 VA: 0x14D0240
	public bool get_havePropertiesChanged() { }

	// RVA: 0x14CBB20 Offset: 0x14CBC21 VA: 0x14CBB20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x14D0250 Offset: 0x14D0351 VA: 0x14D0250
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x14D0260 Offset: 0x14D0361 VA: 0x14D0260
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x14CCE50 Offset: 0x14CCF51 VA: 0x14CCE50
	public Transform get_transform() { }

	// RVA: 0x14CCF00 Offset: 0x14CD001 VA: 0x14CCF00
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x140690 Offset: 0x140791 VA: 0x140690
	// RVA: 0x14D0270 Offset: 0x14D0371 VA: 0x14D0270 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406A0 Offset: 0x1407A1 VA: 0x1406A0
	// RVA: 0x14D0280 Offset: 0x14D0381 VA: 0x14D0280 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x14D0290 Offset: 0x14D0391 VA: 0x14D0290 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x14D02A0 Offset: 0x14D03A1 VA: 0x14D02A0
	public bool get_isVolumetricText() { }

	// RVA: 0x14D02B0 Offset: 0x14D03B1 VA: 0x14D02B0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x14D0340 Offset: 0x14D0441 VA: 0x14D0340
	public Bounds get_bounds() { }

	// RVA: 0x14D03F0 Offset: 0x14D04F1 VA: 0x14D03F0
	public Bounds get_textBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406B0 Offset: 0x1407B1 VA: 0x1406B0
	// RVA: 0x14D06D0 Offset: 0x14D07D1 VA: 0x14D06D0
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406C0 Offset: 0x1407C1 VA: 0x1406C0
	// RVA: 0x14D07C0 Offset: 0x14D08C1 VA: 0x14D07C0
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406D0 Offset: 0x1407D1 VA: 0x1406D0
	// RVA: 0x14D08B0 Offset: 0x14D09B1 VA: 0x14D08B0
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406E0 Offset: 0x1407E1 VA: 0x1406E0
	// RVA: 0x14D09A0 Offset: 0x14D0AA1 VA: 0x14D09A0
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406F0 Offset: 0x1407F1 VA: 0x1406F0
	// RVA: 0x14D0A90 Offset: 0x14D0B91 VA: 0x14D0A90 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140700 Offset: 0x140801 VA: 0x140700
	// RVA: 0x14D0B40 Offset: 0x14D0C41 VA: 0x14D0B40 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x14D0BF0 Offset: 0x14D0CF1 VA: 0x14D0BF0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x14D0D00 Offset: 0x14D0E01 VA: 0x14D0D00 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x14D0D10 Offset: 0x14D0E11 VA: 0x14D0D10 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x14D0D20 Offset: 0x14D0E21 VA: 0x14D0D20 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x14D0D30 Offset: 0x14D0E31 VA: 0x14D0D30 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x14D0D40 Offset: 0x14D0E41 VA: 0x14D0D40
	public float get_maxWidth() { }

	// RVA: 0x14D0D50 Offset: 0x14D0E51 VA: 0x14D0D50
	public float get_maxHeight() { }

	// RVA: 0x14D0D60 Offset: 0x14D0E61 VA: 0x14D0D60
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x14D0E10 Offset: 0x14D0F11 VA: 0x14D0E10 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x14D0FB0 Offset: 0x14D10B1 VA: 0x14D0FB0 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x14D1190 Offset: 0x14D1291 VA: 0x14D1190 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x14D11B0 Offset: 0x14D12B1 VA: 0x14D11B0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x14D11F0 Offset: 0x14D12F1 VA: 0x14D11F0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x14D1200 Offset: 0x14D1301 VA: 0x14D1200 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x14D1210 Offset: 0x14D1311 VA: 0x14D1210 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x14D1220 Offset: 0x14D1321 VA: 0x14D1220 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x14D1230 Offset: 0x14D1331 VA: 0x14D1230 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x14D1240 Offset: 0x14D1341 VA: 0x14D1240 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x14D1250 Offset: 0x14D1351 VA: 0x14D1250 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x14D1260 Offset: 0x14D1361 VA: 0x14D1260 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x14D1270 Offset: 0x14D1371 VA: 0x14D1270 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x14D1330 Offset: 0x14D1431 VA: 0x14D1330
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x14D1430 Offset: 0x14D1531 VA: 0x14D1430
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x14D1440 Offset: 0x14D1541 VA: 0x14D1440
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x14D1450 Offset: 0x14D1551 VA: 0x14D1450 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x14D1460 Offset: 0x14D1561 VA: 0x14D1460 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x14D1470 Offset: 0x14D1571 VA: 0x14D1470 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x14D1480 Offset: 0x14D1581 VA: 0x14D1480 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x14D1490 Offset: 0x14D1591 VA: 0x14D1490 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x14D14A0 Offset: 0x14D15A1 VA: 0x14D14A0 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x14D14B0 Offset: 0x14D15B1 VA: 0x14D14B0 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x14D15F0 Offset: 0x14D16F1 VA: 0x14D15F0 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x14D1710 Offset: 0x14D1811 VA: 0x14D1710 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x14D1720 Offset: 0x14D1821 VA: 0x14D1720 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x14D1730 Offset: 0x14D1831 VA: 0x14D1730
	internal void SetTextInternal(string text) { }

	// RVA: 0x14D1790 Offset: 0x14D1891 VA: 0x14D1790 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x14D17A0 Offset: 0x14D18A1 VA: 0x14D17A0 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x14D17B0 Offset: 0x14D18B1 VA: 0x14D17B0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x14D17C0 Offset: 0x14D18C1 VA: 0x14D17C0 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x14D17D0 Offset: 0x14D18D1 VA: 0x14D17D0 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x14D17E0 Offset: 0x14D18E1 VA: 0x14D17E0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D1880 Offset: 0x14D1981 VA: 0x14D1880 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D18E0 Offset: 0x14D19E1 VA: 0x14D18E0 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D18F0 Offset: 0x14D19F1 VA: 0x14D18F0 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D1900 Offset: 0x14D1A01 VA: 0x14D1900
	protected void ParseInputText() { }

	// RVA: 0x14D2CD0 Offset: 0x14D2DD1 VA: 0x14D2CD0
	public void SetText(string text, bool syncTextInputBox = True) { }

	// RVA: 0x14D2CE0 Offset: 0x14D2DE1 VA: 0x14D2CE0
	public void SetText(string text, float arg0) { }

	// RVA: 0x14D2FF0 Offset: 0x14D30F1 VA: 0x14D2FF0
	public void SetText(string text, float arg0, float arg1) { }

	// RVA: 0x14D3010 Offset: 0x14D3111 VA: 0x14D3010
	public void SetText(string text, float arg0, float arg1, float arg2) { }

	// RVA: 0x14D3030 Offset: 0x14D3131 VA: 0x14D3030
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x14D3050 Offset: 0x14D3151 VA: 0x14D3050
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x14D3060 Offset: 0x14D3161 VA: 0x14D3060
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x14D3070 Offset: 0x14D3171 VA: 0x14D3070
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x14D2D00 Offset: 0x14D2E01 VA: 0x14D2D00
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x14D33D0 Offset: 0x14D34D1 VA: 0x14D33D0
	public void SetText(StringBuilder text) { }

	// RVA: 0x14D3DD0 Offset: 0x14D3ED1 VA: 0x14D3DD0
	public void SetText(char[] text) { }

	// RVA: 0x14D4460 Offset: 0x14D4561 VA: 0x14D4460
	public void SetText(char[] text, int start, int length) { }

	// RVA: 0x14D3DE0 Offset: 0x14D3EE1 VA: 0x14D3DE0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x14D4470 Offset: 0x14D4571 VA: 0x14D4470
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x14D5E70 Offset: 0x14D5F71 VA: 0x14D5E70
	public void SetCharArray(int[] sourceText, int start, int length) { }

	// RVA: 0x14D2640 Offset: 0x14D2741 VA: 0x14D2640
	protected int CharArrayToInternalParsingBuffer(char[] sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D1A30 Offset: 0x14D1B31 VA: 0x14D1A30
	protected int StringToInternalParsingBuffer(string sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D3430 Offset: 0x14D3531 VA: 0x14D3430
	protected int StringBuilderToInternalParsingBuffer(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D7240 Offset: 0x14D7341 VA: 0x14D7240
	private bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D65F0 Offset: 0x14D66F1 VA: 0x14D65F0
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D50E0 Offset: 0x14D51E1 VA: 0x14D50E0
	private bool ReplaceOpeningStyleTag(ref char[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7E90 Offset: 0x14D7F91 VA: 0x14D7E90
	private bool ReplaceOpeningStyleTag(ref StringBuilder sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D76F0 Offset: 0x14D77F1 VA: 0x14D76F0
	private bool ReplaceClosingStyleTag(ref string sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D6AA0 Offset: 0x14D6BA1 VA: 0x14D6AA0
	private bool ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5590 Offset: 0x14D5691 VA: 0x14D5590
	private bool ReplaceClosingStyleTag(ref char[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D8330 Offset: 0x14D8431 VA: 0x14D8330
	private bool ReplaceClosingStyleTag(ref StringBuilder sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14CE670 Offset: 0x14CE771 VA: 0x14CE670
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x14D4B50 Offset: 0x14D4C51 VA: 0x14D4B50
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5A10 Offset: 0x14D5B11 VA: 0x14D5A10
	private bool InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7130 Offset: 0x14D7231 VA: 0x14D7130
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0x14D4FB0 Offset: 0x14D50B1 VA: 0x14D4FB0
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0x14D64C0 Offset: 0x14D65C1 VA: 0x14D64C0
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0x14D7D80 Offset: 0x14D7E81 VA: 0x14D7D80
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0x14D87B0 Offset: 0x14D88B1 VA: 0x14D87B0
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0x14D8BE0 Offset: 0x14D8CE1 VA: 0x14D8BE0
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8AE0 Offset: 0x14D8BE1 VA: 0x14D8AE0
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8CE0 Offset: 0x14D8DE1 VA: 0x14D8CE0
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1B90 Offset: 0x23E1C91 VA: 0x23E1B90
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1CC0 Offset: 0x23E1DC1 VA: 0x23E1CC0
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1C30 Offset: 0x23E1D31 VA: 0x23E1C30
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1D60 Offset: 0x23E1E61 VA: 0x23E1D60
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x14D3080 Offset: 0x14D3181 VA: 0x14D3080
	private void AddFloatToCharArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x14D8E00 Offset: 0x14D8F01 VA: 0x14D8E00
	private void AddIntegerToCharArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x14D8F60 Offset: 0x14D9061 VA: 0x14D8F60 Slot: 114
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x14D8F70 Offset: 0x14D9071 VA: 0x14D8F70 Slot: 115
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x14D8F80 Offset: 0x14D9081 VA: 0x14D8F80
	public Vector2 GetPreferredValues() { }

	// RVA: 0x14D9000 Offset: 0x14D9101 VA: 0x14D9000
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x14D9290 Offset: 0x14D9391 VA: 0x14D9290
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x14D9440 Offset: 0x14D9541 VA: 0x14D9440
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x14D0E40 Offset: 0x14D0F41 VA: 0x14D0E40
	protected float GetPreferredWidth() { }

	// RVA: 0x14D9170 Offset: 0x14D9271 VA: 0x14D9170
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x14D0FE0 Offset: 0x14D10E1 VA: 0x14D0FE0
	protected float GetPreferredHeight() { }

	// RVA: 0x14D91E0 Offset: 0x14D92E1 VA: 0x14D91E0
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x14D95C0 Offset: 0x14D96C1 VA: 0x14D95C0
	public Vector2 GetRenderedValues() { }

	// RVA: 0x14D9690 Offset: 0x14D9791 VA: 0x14D9690
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11A0 Offset: 0x14D12A1 VA: 0x14D11A0
	private float GetRenderedWidth() { }

	// RVA: 0x14D9A90 Offset: 0x14D9B91 VA: 0x14D9A90
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11D0 Offset: 0x14D12D1 VA: 0x14D11D0
	private float GetRenderedHeight() { }

	// RVA: 0x14D9AA0 Offset: 0x14D9BA1 VA: 0x14D9AA0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x14D9AC0 Offset: 0x14D9BC1 VA: 0x14D9AC0 Slot: 116
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x14E17A0 Offset: 0x14E18A1 VA: 0x14E17A0 Slot: 117
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x14E17B0 Offset: 0x14E18B1 VA: 0x14E17B0 Slot: 118
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x14D0410 Offset: 0x14D0511 VA: 0x14D0410
	protected Bounds GetTextBounds() { }

	// RVA: 0x14D9770 Offset: 0x14D9871 VA: 0x14D9770
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x14E17C0 Offset: 0x14E18C1 VA: 0x14E17C0
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x14E1BE0 Offset: 0x14E1CE1 VA: 0x14E1BE0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x14E1E70 Offset: 0x14E1F71 VA: 0x14E1E70 Slot: 119
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x14E1E80 Offset: 0x14E1F81 VA: 0x14E1E80 Slot: 120
	public virtual void ComputeMarginSize() { }

	// RVA: 0x14E1E90 Offset: 0x14E1F91 VA: 0x14E1E90
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x14E1390 Offset: 0x14E1491 VA: 0x14E1390
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x14E0EE0 Offset: 0x14E0FE1 VA: 0x14E0EE0
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x14E2580 Offset: 0x14E2681 VA: 0x14E2580 Slot: 121
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x14E30E0 Offset: 0x14E31E1 VA: 0x14E30E0 Slot: 122
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x14E38B0 Offset: 0x14E39B1 VA: 0x14E38B0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E4000 Offset: 0x14E4101 VA: 0x14E4000 Slot: 124
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x14E4F20 Offset: 0x14E5021 VA: 0x14E4F20 Slot: 125
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E5670 Offset: 0x14E5771 VA: 0x14E5670 Slot: 126
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x14E68A0 Offset: 0x14E69A1 VA: 0x14E68A0 Slot: 127
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x14E6E20 Offset: 0x14E6F21 VA: 0x14E6E20
	protected void LoadDefaultSettings() { }

	// RVA: 0x14E71E0 Offset: 0x14E72E1 VA: 0x14E71E0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7210 Offset: 0x14E7311 VA: 0x14E7210
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E6700 Offset: 0x14E6801 VA: 0x14E6700
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7490 Offset: 0x14E7591 VA: 0x14E7490
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x14E7520 Offset: 0x14E7621 VA: 0x14E7520
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x14E75B0 Offset: 0x14E76B1 VA: 0x14E75B0
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x14E79C0 Offset: 0x14E7AC1 VA: 0x14E79C0 Slot: 128
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x14E79D0 Offset: 0x14E7AD1 VA: 0x14E79D0 Slot: 129
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x14E79E0 Offset: 0x14E7AE1 VA: 0x14E79E0 Slot: 130
	public virtual void ClearMesh() { }

	// RVA: 0x14E79F0 Offset: 0x14E7AF1 VA: 0x14E79F0 Slot: 131
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x14E7A00 Offset: 0x14E7B01 VA: 0x14E7A00 Slot: 132
	public virtual string GetParsedText() { }

	// RVA: 0x14CF940 Offset: 0x14CFA41 VA: 0x14CF940
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x14CF800 Offset: 0x14CF901 VA: 0x14CF800
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x14E6860 Offset: 0x14E6961 VA: 0x14E6860
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x14E7B20 Offset: 0x14E7C21 VA: 0x14E7B20
	protected float PackUV(float x, float y) { }

	// RVA: 0x14E7B60 Offset: 0x14E7C61 VA: 0x14E7B60 Slot: 133
	internal virtual void InternalUpdate() { }

	// RVA: 0x14E7B70 Offset: 0x14E7C71 VA: 0x14E7B70
	protected int HexToInt(char hex) { }

	// RVA: 0x14D7070 Offset: 0x14D7171 VA: 0x14D7070
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x14D88D0 Offset: 0x14D89D1 VA: 0x14D88D0
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x14D7CC0 Offset: 0x14D7DC1 VA: 0x14D7CC0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x14D6F20 Offset: 0x14D7021 VA: 0x14D6F20
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x14D8990 Offset: 0x14D8A91 VA: 0x14D8990
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x14D7B70 Offset: 0x14D7C71 VA: 0x14D7B70
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x14E7BA0 Offset: 0x14E7CA1 VA: 0x14E7BA0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x14E8000 Offset: 0x14E8101 VA: 0x14E8000
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x14E8290 Offset: 0x14E8391 VA: 0x14E8290
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x14E8540 Offset: 0x14E8641 VA: 0x14E8540
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x14E8350 Offset: 0x14E8451 VA: 0x14E8350
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x14DC210 Offset: 0x14DC311 VA: 0x14DC210
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x14E8570 Offset: 0x14E8671 VA: 0x14E8570
	protected void .ctor() { }

	// RVA: 0x14E9110 Offset: 0x14E9211 VA: 0x14E9110
	private static void .cctor() { }
}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 5864
{
	// Fields
	[SerializeField] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	[TextAreaAttribute] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	protected string m_text; // 0xC0
	[SerializeField] // RVA: 0x13FE90 Offset: 0x13FF91 VA: 0x13FE90
	protected ITextPreprocessor m_TextPreprocessor; // 0xC8
	[SerializeField] // RVA: 0x13FEA0 Offset: 0x13FFA1 VA: 0x13FEA0
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x13FEB0 Offset: 0x13FFB1 VA: 0x13FEB0
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x13FEC0 Offset: 0x13FFC1 VA: 0x13FEC0
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x168
	[SerializeField] // RVA: 0x13FED0 Offset: 0x13FFD1 VA: 0x13FED0
	protected Material[] m_fontSharedMaterials; // 0x170
	[SerializeField] // RVA: 0x13FEE0 Offset: 0x13FFE1 VA: 0x13FEE0
	protected Material m_fontMaterial; // 0x178
	[SerializeField] // RVA: 0x13FEF0 Offset: 0x13FFF1 VA: 0x13FEF0
	protected Material[] m_fontMaterials; // 0x180
	protected bool m_isMaterialDirty; // 0x188
	[SerializeField] // RVA: 0x13FF00 Offset: 0x140001 VA: 0x13FF00
	protected Color32 m_fontColor32; // 0x18C
	[SerializeField] // RVA: 0x13FF10 Offset: 0x140011 VA: 0x13FF10
	protected Color m_fontColor; // 0x190
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x1A0
	protected Color32 m_strikethroughColor; // 0x1A4
	[SerializeField] // RVA: 0x13FF20 Offset: 0x140021 VA: 0x13FF20
	protected bool m_enableVertexGradient; // 0x1A8
	[SerializeField] // RVA: 0x13FF30 Offset: 0x140031 VA: 0x13FF30
	protected ColorMode m_colorMode; // 0x1AC
	[SerializeField] // RVA: 0x13FF40 Offset: 0x140041 VA: 0x13FF40
	protected VertexGradient m_fontColorGradient; // 0x1B0
	[SerializeField] // RVA: 0x13FF50 Offset: 0x140051 VA: 0x13FF50
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x13FF60 Offset: 0x140061 VA: 0x13FF60
	protected TMP_SpriteAsset m_spriteAsset; // 0x1F8
	[SerializeField] // RVA: 0x13FF70 Offset: 0x140071 VA: 0x13FF70
	protected bool m_tintAllSprites; // 0x200
	protected bool m_tintSprite; // 0x201
	protected Color32 m_spriteColor; // 0x204
	[SerializeField] // RVA: 0x13FF80 Offset: 0x140081 VA: 0x13FF80
	protected TMP_StyleSheet m_StyleSheet; // 0x208
	internal TMP_Style m_TextStyle; // 0x210
	[SerializeField] // RVA: 0x13FF90 Offset: 0x140091 VA: 0x13FF90
	protected int m_TextStyleHashCode; // 0x218
	[SerializeField] // RVA: 0x13FFA0 Offset: 0x1400A1 VA: 0x13FFA0
	protected bool m_overrideHtmlColors; // 0x21C
	[SerializeField] // RVA: 0x13FFB0 Offset: 0x1400B1 VA: 0x13FFB0
	protected Color32 m_faceColor; // 0x220
	protected Color32 m_outlineColor; // 0x224
	protected float m_outlineWidth; // 0x228
	[SerializeField] // RVA: 0x13FFC0 Offset: 0x1400C1 VA: 0x13FFC0
	protected float m_fontSize; // 0x22C
	protected float m_currentFontSize; // 0x230
	[SerializeField] // RVA: 0x13FFD0 Offset: 0x1400D1 VA: 0x13FFD0
	protected float m_fontSizeBase; // 0x234
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x238
	[SerializeField] // RVA: 0x13FFE0 Offset: 0x1400E1 VA: 0x13FFE0
	protected FontWeight m_fontWeight; // 0x258
	protected FontWeight m_FontWeightInternal; // 0x25C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x260
	[SerializeField] // RVA: 0x13FFF0 Offset: 0x1400F1 VA: 0x13FFF0
	protected bool m_enableAutoSizing; // 0x280
	protected float m_maxFontSize; // 0x284
	protected float m_minFontSize; // 0x288
	protected int m_AutoSizeIterationCount; // 0x28C
	protected int m_AutoSizeMaxIterationCount; // 0x290
	protected bool m_IsAutoSizePointSizeSet; // 0x294
	[SerializeField] // RVA: 0x140000 Offset: 0x140101 VA: 0x140000
	protected float m_fontSizeMin; // 0x298
	[SerializeField] // RVA: 0x140010 Offset: 0x140111 VA: 0x140010
	protected float m_fontSizeMax; // 0x29C
	[SerializeField] // RVA: 0x140020 Offset: 0x140121 VA: 0x140020
	protected FontStyles m_fontStyle; // 0x2A0
	protected FontStyles m_FontStyleInternal; // 0x2A4
	protected TMP_FontStyleStack m_fontStyleStack; // 0x2A8
	protected bool m_isUsingBold; // 0x2B2
	[SerializeField] // RVA: 0x140030 Offset: 0x140131 VA: 0x140030
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x2B4
	[SerializeField] // RVA: 0x140040 Offset: 0x140141 VA: 0x140040
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x2B8
	[SerializeField] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	[FormerlySerializedAsAttribute] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	protected TextAlignmentOptions m_textAlignment; // 0x2BC
	protected HorizontalAlignmentOptions m_lineJustification; // 0x2C0
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2C8
	protected Vector3[] m_textContainerLocalCorners; // 0x2E8
	[SerializeField] // RVA: 0x1400A0 Offset: 0x1401A1 VA: 0x1400A0
	protected float m_characterSpacing; // 0x2F0
	protected float m_cSpacing; // 0x2F4
	protected float m_monoSpacing; // 0x2F8
	[SerializeField] // RVA: 0x1400B0 Offset: 0x1401B1 VA: 0x1400B0
	protected float m_wordSpacing; // 0x2FC
	[SerializeField] // RVA: 0x1400C0 Offset: 0x1401C1 VA: 0x1400C0
	protected float m_lineSpacing; // 0x300
	protected float m_lineSpacingDelta; // 0x304
	protected float m_lineHeight; // 0x308
	protected bool m_IsDrivenLineSpacing; // 0x30C
	[SerializeField] // RVA: 0x1400D0 Offset: 0x1401D1 VA: 0x1400D0
	protected float m_lineSpacingMax; // 0x310
	[SerializeField] // RVA: 0x1400E0 Offset: 0x1401E1 VA: 0x1400E0
	protected float m_paragraphSpacing; // 0x314
	[SerializeField] // RVA: 0x1400F0 Offset: 0x1401F1 VA: 0x1400F0
	protected float m_charWidthMaxAdj; // 0x318
	protected float m_charWidthAdjDelta; // 0x31C
	[SerializeField] // RVA: 0x140100 Offset: 0x140201 VA: 0x140100
	protected bool m_enableWordWrapping; // 0x320
	protected bool m_isCharacterWrappingEnabled; // 0x321
	protected bool m_isNonBreakingSpace; // 0x322
	protected bool m_isIgnoringAlignment; // 0x323
	[SerializeField] // RVA: 0x140110 Offset: 0x140211 VA: 0x140110
	protected float m_wordWrappingRatios; // 0x324
	[SerializeField] // RVA: 0x140120 Offset: 0x140221 VA: 0x140120
	protected TextOverflowModes m_overflowMode; // 0x328
	protected int m_firstOverflowCharacterIndex; // 0x32C
	[SerializeField] // RVA: 0x140130 Offset: 0x140231 VA: 0x140130
	protected TMP_Text m_linkedTextComponent; // 0x330
	[SerializeField] // RVA: 0x140140 Offset: 0x140241 VA: 0x140140
	internal TMP_Text parentLinkedComponent; // 0x338
	protected bool m_isTextTruncated; // 0x340
	[SerializeField] // RVA: 0x140150 Offset: 0x140251 VA: 0x140150
	protected bool m_enableKerning; // 0x341
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x344
	[SerializeField] // RVA: 0x140160 Offset: 0x140261 VA: 0x140160
	protected bool m_enableExtraPadding; // 0x348
	[SerializeField] // RVA: 0x140170 Offset: 0x140271 VA: 0x140170
	protected bool checkPaddingRequired; // 0x349
	[SerializeField] // RVA: 0x140180 Offset: 0x140281 VA: 0x140180
	protected bool m_isRichText; // 0x34A
	[SerializeField] // RVA: 0x140190 Offset: 0x140291 VA: 0x140190
	protected bool m_parseCtrlCharacters; // 0x34B
	protected bool m_isOverlay; // 0x34C
	[SerializeField] // RVA: 0x1401A0 Offset: 0x1402A1 VA: 0x1401A0
	protected bool m_isOrthographic; // 0x34D
	[SerializeField] // RVA: 0x1401B0 Offset: 0x1402B1 VA: 0x1401B0
	protected bool m_isCullingEnabled; // 0x34E
	protected bool m_isMaskingEnabled; // 0x34F
	protected bool isMaskUpdateRequired; // 0x350
	protected bool m_ignoreCulling; // 0x351
	[SerializeField] // RVA: 0x1401C0 Offset: 0x1402C1 VA: 0x1401C0
	protected TextureMappingOptions m_horizontalMapping; // 0x354
	[SerializeField] // RVA: 0x1401D0 Offset: 0x1402D1 VA: 0x1401D0
	protected TextureMappingOptions m_verticalMapping; // 0x358
	[SerializeField] // RVA: 0x1401E0 Offset: 0x1402E1 VA: 0x1401E0
	protected float m_uvLineOffset; // 0x35C
	protected TextRenderFlags m_renderMode; // 0x360
	[SerializeField] // RVA: 0x1401F0 Offset: 0x1402F1 VA: 0x1401F0
	protected VertexSortingOrder m_geometrySortingOrder; // 0x364
	[SerializeField] // RVA: 0x140200 Offset: 0x140301 VA: 0x140200
	protected bool m_IsTextObjectScaleStatic; // 0x368
	[SerializeField] // RVA: 0x140210 Offset: 0x140311 VA: 0x140210
	protected bool m_VertexBufferAutoSizeReduction; // 0x369
	protected int m_firstVisibleCharacter; // 0x36C
	protected int m_maxVisibleCharacters; // 0x370
	protected int m_maxVisibleWords; // 0x374
	protected int m_maxVisibleLines; // 0x378
	[SerializeField] // RVA: 0x140220 Offset: 0x140321 VA: 0x140220
	protected bool m_useMaxVisibleDescender; // 0x37C
	[SerializeField] // RVA: 0x140230 Offset: 0x140331 VA: 0x140230
	protected int m_pageToDisplay; // 0x380
	protected bool m_isNewPage; // 0x384
	[SerializeField] // RVA: 0x140240 Offset: 0x140341 VA: 0x140240
	protected Vector4 m_margin; // 0x388
	protected float m_marginLeft; // 0x398
	protected float m_marginRight; // 0x39C
	protected float m_marginWidth; // 0x3A0
	protected float m_marginHeight; // 0x3A4
	protected float m_width; // 0x3A8
	protected TMP_TextInfo m_textInfo; // 0x3B0
	protected bool m_havePropertiesChanged; // 0x3B8
	[SerializeField] // RVA: 0x140250 Offset: 0x140351 VA: 0x140250
	protected bool m_isUsingLegacyAnimationComponent; // 0x3B9
	protected Transform m_transform; // 0x3C0
	protected RectTransform m_rectTransform; // 0x3C8
	protected Vector2 m_PreviousRectTransformSize; // 0x3D0
	protected Vector2 m_PreviousPivotPosition; // 0x3D8
	[CompilerGeneratedAttribute] // RVA: 0x140260 Offset: 0x140361 VA: 0x140260
	private bool <autoSizeTextContainer>k__BackingField; // 0x3E0
	protected bool m_autoSizeTextContainer; // 0x3E1
	protected Mesh m_mesh; // 0x3E8
	[SerializeField] // RVA: 0x140270 Offset: 0x140371 VA: 0x140270
	protected bool m_isVolumetricText; // 0x3F0
	[CompilerGeneratedAttribute] // RVA: 0x140280 Offset: 0x140381 VA: 0x140280
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x140290 Offset: 0x140391 VA: 0x140290
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1402A0 Offset: 0x1403A1 VA: 0x1402A0
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3F8
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x400
	protected float m_flexibleHeight; // 0x408
	protected float m_flexibleWidth; // 0x40C
	protected float m_minWidth; // 0x410
	protected float m_minHeight; // 0x414
	protected float m_maxWidth; // 0x418
	protected float m_maxHeight; // 0x41C
	protected LayoutElement m_LayoutElement; // 0x420
	protected float m_preferredWidth; // 0x428
	protected float m_renderedWidth; // 0x42C
	protected bool m_isPreferredWidthDirty; // 0x430
	protected float m_preferredHeight; // 0x434
	protected float m_renderedHeight; // 0x438
	protected bool m_isPreferredHeightDirty; // 0x43C
	protected bool m_isCalculatingPreferredValues; // 0x43D
	protected int m_layoutPriority; // 0x440
	protected bool m_isLayoutDirty; // 0x444
	protected bool m_isAwake; // 0x445
	internal bool m_isWaitingOnResourceLoad; // 0x446
	internal bool m_isInputParsingRequired; // 0x447
	internal TMP_Text.TextInputSources m_inputSource; // 0x448
	protected float m_fontScale; // 0x44C
	protected float m_fontScaleMultiplier; // 0x450
	protected char[] m_htmlTag; // 0x458
	protected RichTextTagAttribute[] m_xmlAttribute; // 0x460
	protected float[] m_attributeParameterValues; // 0x468
	protected float tag_LineIndent; // 0x470
	protected float tag_Indent; // 0x474
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x478
	protected bool tag_NoParsing; // 0x498
	protected bool m_isParsingText; // 0x499
	protected Matrix4x4 m_FXMatrix; // 0x49C
	protected bool m_isFXMatrixSet; // 0x4DC
	protected TMP_Text.UnicodeChar[] m_InternalParsingBuffer; // 0x4E0
	protected int m_InternalParsingBufferSize; // 0x4E8
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x4F0
	protected char[] m_input_CharArray; // 0x4F8
	private int m_charArray_Length; // 0x500
	protected int m_totalCharacterCount; // 0x504
	protected WordWrapState m_SavedWordWrapState; // 0x508
	protected WordWrapState m_SavedLineState; // 0x880
	protected WordWrapState m_SavedEllipsisState; // 0xBF8
	protected WordWrapState m_SavedLastValidState; // 0xF70
	protected WordWrapState m_SavedSoftLineBreakState; // 0x12E8
	internal TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1660
	protected int m_characterCount; // 0x19F8
	protected int m_firstCharacterOfLine; // 0x19FC
	protected int m_firstVisibleCharacterOfLine; // 0x1A00
	protected int m_lastCharacterOfLine; // 0x1A04
	protected int m_lastVisibleCharacterOfLine; // 0x1A08
	protected int m_lineNumber; // 0x1A0C
	protected int m_lineVisibleCharacterCount; // 0x1A10
	protected int m_pageNumber; // 0x1A14
	protected float m_PageAscender; // 0x1A18
	protected float m_maxTextAscender; // 0x1A1C
	protected float m_maxCapHeight; // 0x1A20
	protected float m_ElementAscender; // 0x1A24
	protected float m_ElementDescender; // 0x1A28
	protected float m_maxLineAscender; // 0x1A2C
	protected float m_maxLineDescender; // 0x1A30
	protected float m_startOfLineAscender; // 0x1A34
	protected float m_startOfLineDescender; // 0x1A38
	protected float m_lineOffset; // 0x1A3C
	protected Extents m_meshExtents; // 0x1A40
	protected Color32 m_htmlColor; // 0x1A50
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x1A58
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x1A78
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x1A98
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x1AB8
	protected TMP_ColorGradient m_colorGradientPreset; // 0x1AE8
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x1AF0
	protected bool m_colorGradientPresetIsTinted; // 0x1B18
	protected float m_tabSpacing; // 0x1B1C
	protected float m_spacing; // 0x1B20
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x1B28
	protected int m_TextStyleStackDepth; // 0x1B30
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x1B38
	protected int m_ItalicAngle; // 0x1B58
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x1B60
	protected float m_padding; // 0x1B80
	protected float m_baselineOffset; // 0x1B84
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x1B88
	protected float m_xAdvance; // 0x1BA8
	protected TMP_TextElementType m_textElementType; // 0x1BAC
	protected TMP_TextElement m_cached_TextElement; // 0x1BB0
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x1BB8
	protected TMP_Text.SpecialCharacter m_Underline; // 0x1BD8
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x1BF8
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x1C00
	protected int m_spriteCount; // 0x1C08
	protected int m_spriteIndex; // 0x1C0C
	protected int m_spriteAnimationID; // 0x1C10
	protected bool m_ignoreActiveState; // 0x1C14
	private readonly Decimal[] k_Power; // 0x1C18
	protected static Vector2 k_LargePositiveVector2; // 0x18
	protected static Vector2 k_LargeNegativeVector2; // 0x20
	protected static float k_LargePositiveFloat; // 0x28
	protected static float k_LargeNegativeFloat; // 0x2C
	protected static int k_LargePositiveInt; // 0x30
	protected static int k_LargeNegativeInt; // 0x34

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public float fontScale { get; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x14CDCA0 Offset: 0x14CDDA1 VA: 0x14CDCA0 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x14CDCB0 Offset: 0x14CDDB1 VA: 0x14CDCB0 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x14CDD60 Offset: 0x14CDE61 VA: 0x14CDD60
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x14CDD70 Offset: 0x14CDE71 VA: 0x14CDD70
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x14CDD80 Offset: 0x14CDE81 VA: 0x14CDD80
	public bool get_isRightToLeftText() { }

	// RVA: 0x14CDD90 Offset: 0x14CDE91 VA: 0x14CDD90
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x14CDE00 Offset: 0x14CDF01 VA: 0x14CDE00
	public TMP_FontAsset get_font() { }

	// RVA: 0x14CDE10 Offset: 0x14CDF11 VA: 0x14CDE10
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x14CDF00 Offset: 0x14CE001 VA: 0x14CDF00 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x14CDF10 Offset: 0x14CE011 VA: 0x14CDF10 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x14CDFF0 Offset: 0x14CE0F1 VA: 0x14CDFF0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x14CE000 Offset: 0x14CE101 VA: 0x14CE000 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x14CE060 Offset: 0x14CE161 VA: 0x14CE060
	public Material get_fontMaterial() { }

	// RVA: 0x14CE080 Offset: 0x14CE181 VA: 0x14CE080
	public void set_fontMaterial(Material value) { }

	// RVA: 0x14CE1A0 Offset: 0x14CE2A1 VA: 0x14CE1A0 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x14CE1C0 Offset: 0x14CE2C1 VA: 0x14CE1C0 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x14CE220 Offset: 0x14CE321 VA: 0x14CE220 Slot: 22
	public override Color get_color() { }

	// RVA: 0x14CE240 Offset: 0x14CE341 VA: 0x14CE240 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x14CE2F0 Offset: 0x14CE3F1 VA: 0x14CE2F0
	public float get_alpha() { }

	// RVA: 0x14CE300 Offset: 0x14CE401 VA: 0x14CE300
	public void set_alpha(float value) { }

	// RVA: 0x14CE330 Offset: 0x14CE431 VA: 0x14CE330
	public bool get_enableVertexGradient() { }

	// RVA: 0x14CE340 Offset: 0x14CE441 VA: 0x14CE340
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x14CE380 Offset: 0x14CE481 VA: 0x14CE380
	public VertexGradient get_colorGradient() { }

	// RVA: 0x14CE3B0 Offset: 0x14CE4B1 VA: 0x14CE3B0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x14CE3F0 Offset: 0x14CE4F1 VA: 0x14CE3F0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x14CE400 Offset: 0x14CE501 VA: 0x14CE400
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x14CE440 Offset: 0x14CE541 VA: 0x14CE440
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x14CE450 Offset: 0x14CE551 VA: 0x14CE450
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x14CE4B0 Offset: 0x14CE5B1 VA: 0x14CE4B0
	public bool get_tintAllSprites() { }

	// RVA: 0x14CE4C0 Offset: 0x14CE5C1 VA: 0x14CE4C0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x14CE500 Offset: 0x14CE601 VA: 0x14CE500
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x14CE510 Offset: 0x14CE611 VA: 0x14CE510
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x14CE570 Offset: 0x14CE671 VA: 0x14CE570
	public TMP_Style get_textStyle() { }

	// RVA: 0x14CE830 Offset: 0x14CE931 VA: 0x14CE830
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x14CE8A0 Offset: 0x14CE9A1 VA: 0x14CE8A0
	public bool get_overrideColorTags() { }

	// RVA: 0x14CE8B0 Offset: 0x14CE9B1 VA: 0x14CE8B0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x14CE8F0 Offset: 0x14CE9F1 VA: 0x14CE8F0
	public Color32 get_faceColor() { }

	// RVA: 0x14CE9E0 Offset: 0x14CEAE1 VA: 0x14CE9E0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x14CEA80 Offset: 0x14CEB81 VA: 0x14CEA80
	public Color32 get_outlineColor() { }

	// RVA: 0x14CEB70 Offset: 0x14CEC71 VA: 0x14CEB70
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x14CEC00 Offset: 0x14CED01 VA: 0x14CEC00
	public float get_outlineWidth() { }

	// RVA: 0x14CECE0 Offset: 0x14CEDE1 VA: 0x14CECE0
	public void set_outlineWidth(float value) { }

	// RVA: 0x14CED60 Offset: 0x14CEE61 VA: 0x14CED60
	public float get_fontSize() { }

	// RVA: 0x14CED70 Offset: 0x14CEE71 VA: 0x14CED70
	public void set_fontSize(float value) { }

	// RVA: 0x14CEDE0 Offset: 0x14CEEE1 VA: 0x14CEDE0
	public float get_fontScale() { }

	// RVA: 0x14CEDF0 Offset: 0x14CEEF1 VA: 0x14CEDF0
	public FontWeight get_fontWeight() { }

	// RVA: 0x14CEE00 Offset: 0x14CEF01 VA: 0x14CEE00
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x14CEE60 Offset: 0x14CEF61 VA: 0x14CEE60
	public float get_pixelsPerUnit() { }

	// RVA: 0x14CF010 Offset: 0x14CF111 VA: 0x14CF010
	public bool get_enableAutoSizing() { }

	// RVA: 0x14CF020 Offset: 0x14CF121 VA: 0x14CF020
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x14CF080 Offset: 0x14CF181 VA: 0x14CF080
	public float get_fontSizeMin() { }

	// RVA: 0x14CF090 Offset: 0x14CF191 VA: 0x14CF090
	public void set_fontSizeMin(float value) { }

	// RVA: 0x14CF0E0 Offset: 0x14CF1E1 VA: 0x14CF0E0
	public float get_fontSizeMax() { }

	// RVA: 0x14CF0F0 Offset: 0x14CF1F1 VA: 0x14CF0F0
	public void set_fontSizeMax(float value) { }

	// RVA: 0x14CF140 Offset: 0x14CF241 VA: 0x14CF140
	public FontStyles get_fontStyle() { }

	// RVA: 0x14CF150 Offset: 0x14CF251 VA: 0x14CF150
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x14CF1B0 Offset: 0x14CF2B1 VA: 0x14CF1B0
	public bool get_isUsingBold() { }

	// RVA: 0x14CF1C0 Offset: 0x14CF2C1 VA: 0x14CF1C0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x14CF1D0 Offset: 0x14CF2D1 VA: 0x14CF1D0
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x14CF200 Offset: 0x14CF301 VA: 0x14CF200
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x14CF210 Offset: 0x14CF311 VA: 0x14CF210
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x14CF240 Offset: 0x14CF341 VA: 0x14CF240
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x14CF250 Offset: 0x14CF351 VA: 0x14CF250
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x14CF2A0 Offset: 0x14CF3A1 VA: 0x14CF2A0
	public float get_characterSpacing() { }

	// RVA: 0x14CF2B0 Offset: 0x14CF3B1 VA: 0x14CF2B0
	public void set_characterSpacing(float value) { }

	// RVA: 0x14CF310 Offset: 0x14CF411 VA: 0x14CF310
	public float get_wordSpacing() { }

	// RVA: 0x14CF320 Offset: 0x14CF421 VA: 0x14CF320
	public void set_wordSpacing(float value) { }

	// RVA: 0x14CF380 Offset: 0x14CF481 VA: 0x14CF380
	public float get_lineSpacing() { }

	// RVA: 0x14CF390 Offset: 0x14CF491 VA: 0x14CF390
	public void set_lineSpacing(float value) { }

	// RVA: 0x14CF3F0 Offset: 0x14CF4F1 VA: 0x14CF3F0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x14CF400 Offset: 0x14CF501 VA: 0x14CF400
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x14CF460 Offset: 0x14CF561 VA: 0x14CF460
	public float get_paragraphSpacing() { }

	// RVA: 0x14CF470 Offset: 0x14CF571 VA: 0x14CF470
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x14CF4D0 Offset: 0x14CF5D1 VA: 0x14CF4D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x14CF4E0 Offset: 0x14CF5E1 VA: 0x14CF4E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x14CF540 Offset: 0x14CF641 VA: 0x14CF540
	public bool get_enableWordWrapping() { }

	// RVA: 0x14CF550 Offset: 0x14CF651 VA: 0x14CF550
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x14CF5C0 Offset: 0x14CF6C1 VA: 0x14CF5C0
	public float get_wordWrappingRatios() { }

	// RVA: 0x14CF5D0 Offset: 0x14CF6D1 VA: 0x14CF5D0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x14CF630 Offset: 0x14CF731 VA: 0x14CF630
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x14CF640 Offset: 0x14CF741 VA: 0x14CF640
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x14CF6A0 Offset: 0x14CF7A1 VA: 0x14CF6A0
	public bool get_isTextOverflowing() { }

	// RVA: 0x14CF6B0 Offset: 0x14CF7B1 VA: 0x14CF6B0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x14CF6C0 Offset: 0x14CF7C1 VA: 0x14CF6C0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x14CF6D0 Offset: 0x14CF7D1 VA: 0x14CF6D0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x14CFA50 Offset: 0x14CFB51 VA: 0x14CFA50
	public bool get_isTextTruncated() { }

	// RVA: 0x14CFA60 Offset: 0x14CFB61 VA: 0x14CFA60
	public bool get_enableKerning() { }

	// RVA: 0x14CFA70 Offset: 0x14CFB71 VA: 0x14CFA70
	public void set_enableKerning(bool value) { }

	// RVA: 0x14CFAE0 Offset: 0x14CFBE1 VA: 0x14CFAE0
	public bool get_extraPadding() { }

	// RVA: 0x14CFAF0 Offset: 0x14CFBF1 VA: 0x14CFAF0
	public void set_extraPadding(bool value) { }

	// RVA: 0x14CFB60 Offset: 0x14CFC61 VA: 0x14CFB60
	public bool get_richText() { }

	// RVA: 0x14CFB70 Offset: 0x14CFC71 VA: 0x14CFB70
	public void set_richText(bool value) { }

	// RVA: 0x14CFBE0 Offset: 0x14CFCE1 VA: 0x14CFBE0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x14CFBF0 Offset: 0x14CFCF1 VA: 0x14CFBF0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x14CFC60 Offset: 0x14CFD61 VA: 0x14CFC60
	public bool get_isOverlay() { }

	// RVA: 0x14CFC70 Offset: 0x14CFD71 VA: 0x14CFC70
	public void set_isOverlay(bool value) { }

	// RVA: 0x14CFCE0 Offset: 0x14CFDE1 VA: 0x14CFCE0
	public bool get_isOrthographic() { }

	// RVA: 0x14CFCF0 Offset: 0x14CFDF1 VA: 0x14CFCF0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x14CFD30 Offset: 0x14CFE31 VA: 0x14CFD30
	public bool get_enableCulling() { }

	// RVA: 0x14CFD40 Offset: 0x14CFE41 VA: 0x14CFD40
	public void set_enableCulling(bool value) { }

	// RVA: 0x14CFD90 Offset: 0x14CFE91 VA: 0x14CFD90
	public bool get_ignoreVisibility() { }

	// RVA: 0x14CFDA0 Offset: 0x14CFEA1 VA: 0x14CFDA0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x14CFDD0 Offset: 0x14CFED1 VA: 0x14CFDD0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x14CFDE0 Offset: 0x14CFEE1 VA: 0x14CFDE0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE10 Offset: 0x14CFF11 VA: 0x14CFE10
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x14CFE20 Offset: 0x14CFF21 VA: 0x14CFE20
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE50 Offset: 0x14CFF51 VA: 0x14CFE50
	public float get_mappingUvLineOffset() { }

	// RVA: 0x14CFE60 Offset: 0x14CFF61 VA: 0x14CFE60
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x14CFE90 Offset: 0x14CFF91 VA: 0x14CFE90
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x14CFEA0 Offset: 0x14CFFA1 VA: 0x14CFEA0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x14CFEC0 Offset: 0x14CFFC1 VA: 0x14CFEC0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x14CFED0 Offset: 0x14CFFD1 VA: 0x14CFED0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x14CFEF0 Offset: 0x14CFFF1 VA: 0x14CFEF0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x14CFF00 Offset: 0x14D0001 VA: 0x14CFF00
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x14CFF20 Offset: 0x14D0021 VA: 0x14CFF20
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x14CFF30 Offset: 0x14D0031 VA: 0x14CFF30
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x14CFF50 Offset: 0x14D0051 VA: 0x14CFF50
	public int get_firstVisibleCharacter() { }

	// RVA: 0x14CFF60 Offset: 0x14D0061 VA: 0x14CFF60
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x14CFF90 Offset: 0x14D0091 VA: 0x14CFF90
	public int get_maxVisibleCharacters() { }

	// RVA: 0x14CFFA0 Offset: 0x14D00A1 VA: 0x14CFFA0
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x14CFFD0 Offset: 0x14D00D1 VA: 0x14CFFD0
	public int get_maxVisibleWords() { }

	// RVA: 0x14CFFE0 Offset: 0x14D00E1 VA: 0x14CFFE0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x14D0010 Offset: 0x14D0111 VA: 0x14D0010
	public int get_maxVisibleLines() { }

	// RVA: 0x14D0020 Offset: 0x14D0121 VA: 0x14D0020
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x14D0050 Offset: 0x14D0151 VA: 0x14D0050
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x14D0060 Offset: 0x14D0161 VA: 0x14D0060
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x14D00A0 Offset: 0x14D01A1 VA: 0x14D00A0
	public int get_pageToDisplay() { }

	// RVA: 0x14D00B0 Offset: 0x14D01B1 VA: 0x14D00B0
	public void set_pageToDisplay(int value) { }

	// RVA: 0x14D00E0 Offset: 0x14D01E1 VA: 0x14D00E0 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x14D0100 Offset: 0x14D0201 VA: 0x14D0100 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x14D0230 Offset: 0x14D0331 VA: 0x14D0230
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x14D0240 Offset: 0x14D0341 VA: 0x14D0240
	public bool get_havePropertiesChanged() { }

	// RVA: 0x14CBB20 Offset: 0x14CBC21 VA: 0x14CBB20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x14D0250 Offset: 0x14D0351 VA: 0x14D0250
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x14D0260 Offset: 0x14D0361 VA: 0x14D0260
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x14CCE50 Offset: 0x14CCF51 VA: 0x14CCE50
	public Transform get_transform() { }

	// RVA: 0x14CCF00 Offset: 0x14CD001 VA: 0x14CCF00
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x140690 Offset: 0x140791 VA: 0x140690
	// RVA: 0x14D0270 Offset: 0x14D0371 VA: 0x14D0270 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406A0 Offset: 0x1407A1 VA: 0x1406A0
	// RVA: 0x14D0280 Offset: 0x14D0381 VA: 0x14D0280 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x14D0290 Offset: 0x14D0391 VA: 0x14D0290 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x14D02A0 Offset: 0x14D03A1 VA: 0x14D02A0
	public bool get_isVolumetricText() { }

	// RVA: 0x14D02B0 Offset: 0x14D03B1 VA: 0x14D02B0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x14D0340 Offset: 0x14D0441 VA: 0x14D0340
	public Bounds get_bounds() { }

	// RVA: 0x14D03F0 Offset: 0x14D04F1 VA: 0x14D03F0
	public Bounds get_textBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406B0 Offset: 0x1407B1 VA: 0x1406B0
	// RVA: 0x14D06D0 Offset: 0x14D07D1 VA: 0x14D06D0
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406C0 Offset: 0x1407C1 VA: 0x1406C0
	// RVA: 0x14D07C0 Offset: 0x14D08C1 VA: 0x14D07C0
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406D0 Offset: 0x1407D1 VA: 0x1406D0
	// RVA: 0x14D08B0 Offset: 0x14D09B1 VA: 0x14D08B0
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406E0 Offset: 0x1407E1 VA: 0x1406E0
	// RVA: 0x14D09A0 Offset: 0x14D0AA1 VA: 0x14D09A0
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406F0 Offset: 0x1407F1 VA: 0x1406F0
	// RVA: 0x14D0A90 Offset: 0x14D0B91 VA: 0x14D0A90 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140700 Offset: 0x140801 VA: 0x140700
	// RVA: 0x14D0B40 Offset: 0x14D0C41 VA: 0x14D0B40 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x14D0BF0 Offset: 0x14D0CF1 VA: 0x14D0BF0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x14D0D00 Offset: 0x14D0E01 VA: 0x14D0D00 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x14D0D10 Offset: 0x14D0E11 VA: 0x14D0D10 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x14D0D20 Offset: 0x14D0E21 VA: 0x14D0D20 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x14D0D30 Offset: 0x14D0E31 VA: 0x14D0D30 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x14D0D40 Offset: 0x14D0E41 VA: 0x14D0D40
	public float get_maxWidth() { }

	// RVA: 0x14D0D50 Offset: 0x14D0E51 VA: 0x14D0D50
	public float get_maxHeight() { }

	// RVA: 0x14D0D60 Offset: 0x14D0E61 VA: 0x14D0D60
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x14D0E10 Offset: 0x14D0F11 VA: 0x14D0E10 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x14D0FB0 Offset: 0x14D10B1 VA: 0x14D0FB0 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x14D1190 Offset: 0x14D1291 VA: 0x14D1190 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x14D11B0 Offset: 0x14D12B1 VA: 0x14D11B0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x14D11F0 Offset: 0x14D12F1 VA: 0x14D11F0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x14D1200 Offset: 0x14D1301 VA: 0x14D1200 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x14D1210 Offset: 0x14D1311 VA: 0x14D1210 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x14D1220 Offset: 0x14D1321 VA: 0x14D1220 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x14D1230 Offset: 0x14D1331 VA: 0x14D1230 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x14D1240 Offset: 0x14D1341 VA: 0x14D1240 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x14D1250 Offset: 0x14D1351 VA: 0x14D1250 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x14D1260 Offset: 0x14D1361 VA: 0x14D1260 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x14D1270 Offset: 0x14D1371 VA: 0x14D1270 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x14D1330 Offset: 0x14D1431 VA: 0x14D1330
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x14D1430 Offset: 0x14D1531 VA: 0x14D1430
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x14D1440 Offset: 0x14D1541 VA: 0x14D1440
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x14D1450 Offset: 0x14D1551 VA: 0x14D1450 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x14D1460 Offset: 0x14D1561 VA: 0x14D1460 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x14D1470 Offset: 0x14D1571 VA: 0x14D1470 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x14D1480 Offset: 0x14D1581 VA: 0x14D1480 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x14D1490 Offset: 0x14D1591 VA: 0x14D1490 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x14D14A0 Offset: 0x14D15A1 VA: 0x14D14A0 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x14D14B0 Offset: 0x14D15B1 VA: 0x14D14B0 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x14D15F0 Offset: 0x14D16F1 VA: 0x14D15F0 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x14D1710 Offset: 0x14D1811 VA: 0x14D1710 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x14D1720 Offset: 0x14D1821 VA: 0x14D1720 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x14D1730 Offset: 0x14D1831 VA: 0x14D1730
	internal void SetTextInternal(string text) { }

	// RVA: 0x14D1790 Offset: 0x14D1891 VA: 0x14D1790 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x14D17A0 Offset: 0x14D18A1 VA: 0x14D17A0 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x14D17B0 Offset: 0x14D18B1 VA: 0x14D17B0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x14D17C0 Offset: 0x14D18C1 VA: 0x14D17C0 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x14D17D0 Offset: 0x14D18D1 VA: 0x14D17D0 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x14D17E0 Offset: 0x14D18E1 VA: 0x14D17E0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D1880 Offset: 0x14D1981 VA: 0x14D1880 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D18E0 Offset: 0x14D19E1 VA: 0x14D18E0 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D18F0 Offset: 0x14D19F1 VA: 0x14D18F0 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D1900 Offset: 0x14D1A01 VA: 0x14D1900
	protected void ParseInputText() { }

	// RVA: 0x14D2CD0 Offset: 0x14D2DD1 VA: 0x14D2CD0
	public void SetText(string text, bool syncTextInputBox = True) { }

	// RVA: 0x14D2CE0 Offset: 0x14D2DE1 VA: 0x14D2CE0
	public void SetText(string text, float arg0) { }

	// RVA: 0x14D2FF0 Offset: 0x14D30F1 VA: 0x14D2FF0
	public void SetText(string text, float arg0, float arg1) { }

	// RVA: 0x14D3010 Offset: 0x14D3111 VA: 0x14D3010
	public void SetText(string text, float arg0, float arg1, float arg2) { }

	// RVA: 0x14D3030 Offset: 0x14D3131 VA: 0x14D3030
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x14D3050 Offset: 0x14D3151 VA: 0x14D3050
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x14D3060 Offset: 0x14D3161 VA: 0x14D3060
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x14D3070 Offset: 0x14D3171 VA: 0x14D3070
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x14D2D00 Offset: 0x14D2E01 VA: 0x14D2D00
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x14D33D0 Offset: 0x14D34D1 VA: 0x14D33D0
	public void SetText(StringBuilder text) { }

	// RVA: 0x14D3DD0 Offset: 0x14D3ED1 VA: 0x14D3DD0
	public void SetText(char[] text) { }

	// RVA: 0x14D4460 Offset: 0x14D4561 VA: 0x14D4460
	public void SetText(char[] text, int start, int length) { }

	// RVA: 0x14D3DE0 Offset: 0x14D3EE1 VA: 0x14D3DE0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x14D4470 Offset: 0x14D4571 VA: 0x14D4470
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x14D5E70 Offset: 0x14D5F71 VA: 0x14D5E70
	public void SetCharArray(int[] sourceText, int start, int length) { }

	// RVA: 0x14D2640 Offset: 0x14D2741 VA: 0x14D2640
	protected int CharArrayToInternalParsingBuffer(char[] sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D1A30 Offset: 0x14D1B31 VA: 0x14D1A30
	protected int StringToInternalParsingBuffer(string sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D3430 Offset: 0x14D3531 VA: 0x14D3430
	protected int StringBuilderToInternalParsingBuffer(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D7240 Offset: 0x14D7341 VA: 0x14D7240
	private bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D65F0 Offset: 0x14D66F1 VA: 0x14D65F0
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D50E0 Offset: 0x14D51E1 VA: 0x14D50E0
	private bool ReplaceOpeningStyleTag(ref char[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7E90 Offset: 0x14D7F91 VA: 0x14D7E90
	private bool ReplaceOpeningStyleTag(ref StringBuilder sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D76F0 Offset: 0x14D77F1 VA: 0x14D76F0
	private bool ReplaceClosingStyleTag(ref string sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D6AA0 Offset: 0x14D6BA1 VA: 0x14D6AA0
	private bool ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5590 Offset: 0x14D5691 VA: 0x14D5590
	private bool ReplaceClosingStyleTag(ref char[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D8330 Offset: 0x14D8431 VA: 0x14D8330
	private bool ReplaceClosingStyleTag(ref StringBuilder sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14CE670 Offset: 0x14CE771 VA: 0x14CE670
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x14D4B50 Offset: 0x14D4C51 VA: 0x14D4B50
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5A10 Offset: 0x14D5B11 VA: 0x14D5A10
	private bool InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7130 Offset: 0x14D7231 VA: 0x14D7130
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0x14D4FB0 Offset: 0x14D50B1 VA: 0x14D4FB0
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0x14D64C0 Offset: 0x14D65C1 VA: 0x14D64C0
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0x14D7D80 Offset: 0x14D7E81 VA: 0x14D7D80
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0x14D87B0 Offset: 0x14D88B1 VA: 0x14D87B0
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0x14D8BE0 Offset: 0x14D8CE1 VA: 0x14D8BE0
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8AE0 Offset: 0x14D8BE1 VA: 0x14D8AE0
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8CE0 Offset: 0x14D8DE1 VA: 0x14D8CE0
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1B90 Offset: 0x23E1C91 VA: 0x23E1B90
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1CC0 Offset: 0x23E1DC1 VA: 0x23E1CC0
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1C30 Offset: 0x23E1D31 VA: 0x23E1C30
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1D60 Offset: 0x23E1E61 VA: 0x23E1D60
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x14D3080 Offset: 0x14D3181 VA: 0x14D3080
	private void AddFloatToCharArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x14D8E00 Offset: 0x14D8F01 VA: 0x14D8E00
	private void AddIntegerToCharArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x14D8F60 Offset: 0x14D9061 VA: 0x14D8F60 Slot: 114
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x14D8F70 Offset: 0x14D9071 VA: 0x14D8F70 Slot: 115
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x14D8F80 Offset: 0x14D9081 VA: 0x14D8F80
	public Vector2 GetPreferredValues() { }

	// RVA: 0x14D9000 Offset: 0x14D9101 VA: 0x14D9000
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x14D9290 Offset: 0x14D9391 VA: 0x14D9290
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x14D9440 Offset: 0x14D9541 VA: 0x14D9440
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x14D0E40 Offset: 0x14D0F41 VA: 0x14D0E40
	protected float GetPreferredWidth() { }

	// RVA: 0x14D9170 Offset: 0x14D9271 VA: 0x14D9170
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x14D0FE0 Offset: 0x14D10E1 VA: 0x14D0FE0
	protected float GetPreferredHeight() { }

	// RVA: 0x14D91E0 Offset: 0x14D92E1 VA: 0x14D91E0
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x14D95C0 Offset: 0x14D96C1 VA: 0x14D95C0
	public Vector2 GetRenderedValues() { }

	// RVA: 0x14D9690 Offset: 0x14D9791 VA: 0x14D9690
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11A0 Offset: 0x14D12A1 VA: 0x14D11A0
	private float GetRenderedWidth() { }

	// RVA: 0x14D9A90 Offset: 0x14D9B91 VA: 0x14D9A90
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11D0 Offset: 0x14D12D1 VA: 0x14D11D0
	private float GetRenderedHeight() { }

	// RVA: 0x14D9AA0 Offset: 0x14D9BA1 VA: 0x14D9AA0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x14D9AC0 Offset: 0x14D9BC1 VA: 0x14D9AC0 Slot: 116
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x14E17A0 Offset: 0x14E18A1 VA: 0x14E17A0 Slot: 117
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x14E17B0 Offset: 0x14E18B1 VA: 0x14E17B0 Slot: 118
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x14D0410 Offset: 0x14D0511 VA: 0x14D0410
	protected Bounds GetTextBounds() { }

	// RVA: 0x14D9770 Offset: 0x14D9871 VA: 0x14D9770
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x14E17C0 Offset: 0x14E18C1 VA: 0x14E17C0
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x14E1BE0 Offset: 0x14E1CE1 VA: 0x14E1BE0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x14E1E70 Offset: 0x14E1F71 VA: 0x14E1E70 Slot: 119
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x14E1E80 Offset: 0x14E1F81 VA: 0x14E1E80 Slot: 120
	public virtual void ComputeMarginSize() { }

	// RVA: 0x14E1E90 Offset: 0x14E1F91 VA: 0x14E1E90
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x14E1390 Offset: 0x14E1491 VA: 0x14E1390
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x14E0EE0 Offset: 0x14E0FE1 VA: 0x14E0EE0
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x14E2580 Offset: 0x14E2681 VA: 0x14E2580 Slot: 121
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x14E30E0 Offset: 0x14E31E1 VA: 0x14E30E0 Slot: 122
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x14E38B0 Offset: 0x14E39B1 VA: 0x14E38B0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E4000 Offset: 0x14E4101 VA: 0x14E4000 Slot: 124
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x14E4F20 Offset: 0x14E5021 VA: 0x14E4F20 Slot: 125
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E5670 Offset: 0x14E5771 VA: 0x14E5670 Slot: 126
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x14E68A0 Offset: 0x14E69A1 VA: 0x14E68A0 Slot: 127
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x14E6E20 Offset: 0x14E6F21 VA: 0x14E6E20
	protected void LoadDefaultSettings() { }

	// RVA: 0x14E71E0 Offset: 0x14E72E1 VA: 0x14E71E0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7210 Offset: 0x14E7311 VA: 0x14E7210
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E6700 Offset: 0x14E6801 VA: 0x14E6700
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7490 Offset: 0x14E7591 VA: 0x14E7490
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x14E7520 Offset: 0x14E7621 VA: 0x14E7520
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x14E75B0 Offset: 0x14E76B1 VA: 0x14E75B0
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x14E79C0 Offset: 0x14E7AC1 VA: 0x14E79C0 Slot: 128
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x14E79D0 Offset: 0x14E7AD1 VA: 0x14E79D0 Slot: 129
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x14E79E0 Offset: 0x14E7AE1 VA: 0x14E79E0 Slot: 130
	public virtual void ClearMesh() { }

	// RVA: 0x14E79F0 Offset: 0x14E7AF1 VA: 0x14E79F0 Slot: 131
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x14E7A00 Offset: 0x14E7B01 VA: 0x14E7A00 Slot: 132
	public virtual string GetParsedText() { }

	// RVA: 0x14CF940 Offset: 0x14CFA41 VA: 0x14CF940
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x14CF800 Offset: 0x14CF901 VA: 0x14CF800
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x14E6860 Offset: 0x14E6961 VA: 0x14E6860
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x14E7B20 Offset: 0x14E7C21 VA: 0x14E7B20
	protected float PackUV(float x, float y) { }

	// RVA: 0x14E7B60 Offset: 0x14E7C61 VA: 0x14E7B60 Slot: 133
	internal virtual void InternalUpdate() { }

	// RVA: 0x14E7B70 Offset: 0x14E7C71 VA: 0x14E7B70
	protected int HexToInt(char hex) { }

	// RVA: 0x14D7070 Offset: 0x14D7171 VA: 0x14D7070
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x14D88D0 Offset: 0x14D89D1 VA: 0x14D88D0
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x14D7CC0 Offset: 0x14D7DC1 VA: 0x14D7CC0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x14D6F20 Offset: 0x14D7021 VA: 0x14D6F20
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x14D8990 Offset: 0x14D8A91 VA: 0x14D8990
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x14D7B70 Offset: 0x14D7C71 VA: 0x14D7B70
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x14E7BA0 Offset: 0x14E7CA1 VA: 0x14E7BA0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x14E8000 Offset: 0x14E8101 VA: 0x14E8000
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x14E8290 Offset: 0x14E8391 VA: 0x14E8290
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x14E8540 Offset: 0x14E8641 VA: 0x14E8540
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x14E8350 Offset: 0x14E8451 VA: 0x14E8350
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x14DC210 Offset: 0x14DC311 VA: 0x14DC210
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x14E8570 Offset: 0x14E8671 VA: 0x14E8570
	protected void .ctor() { }

	// RVA: 0x14E9110 Offset: 0x14E9211 VA: 0x14E9110
	private static void .cctor() { }
}

public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 5864
{
	// Fields
	[SerializeField] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	[TextAreaAttribute] // RVA: 0x13FE50 Offset: 0x13FF51 VA: 0x13FE50
	protected string m_text; // 0xC0
	[SerializeField] // RVA: 0x13FE90 Offset: 0x13FF91 VA: 0x13FE90
	protected ITextPreprocessor m_TextPreprocessor; // 0xC8
	[SerializeField] // RVA: 0x13FEA0 Offset: 0x13FFA1 VA: 0x13FEA0
	protected bool m_isRightToLeft; // 0xD0
	[SerializeField] // RVA: 0x13FEB0 Offset: 0x13FFB1 VA: 0x13FEB0
	protected TMP_FontAsset m_fontAsset; // 0xD8
	protected TMP_FontAsset m_currentFontAsset; // 0xE0
	protected bool m_isSDFShader; // 0xE8
	[SerializeField] // RVA: 0x13FEC0 Offset: 0x13FFC1 VA: 0x13FEC0
	protected Material m_sharedMaterial; // 0xF0
	protected Material m_currentMaterial; // 0xF8
	protected MaterialReference[] m_materialReferences; // 0x100
	protected Dictionary<int, int> m_materialReferenceIndexLookup; // 0x108
	protected TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x110
	protected int m_currentMaterialIndex; // 0x168
	[SerializeField] // RVA: 0x13FED0 Offset: 0x13FFD1 VA: 0x13FED0
	protected Material[] m_fontSharedMaterials; // 0x170
	[SerializeField] // RVA: 0x13FEE0 Offset: 0x13FFE1 VA: 0x13FEE0
	protected Material m_fontMaterial; // 0x178
	[SerializeField] // RVA: 0x13FEF0 Offset: 0x13FFF1 VA: 0x13FEF0
	protected Material[] m_fontMaterials; // 0x180
	protected bool m_isMaterialDirty; // 0x188
	[SerializeField] // RVA: 0x13FF00 Offset: 0x140001 VA: 0x13FF00
	protected Color32 m_fontColor32; // 0x18C
	[SerializeField] // RVA: 0x13FF10 Offset: 0x140011 VA: 0x13FF10
	protected Color m_fontColor; // 0x190
	protected static Color32 s_colorWhite; // 0x0
	protected Color32 m_underlineColor; // 0x1A0
	protected Color32 m_strikethroughColor; // 0x1A4
	[SerializeField] // RVA: 0x13FF20 Offset: 0x140021 VA: 0x13FF20
	protected bool m_enableVertexGradient; // 0x1A8
	[SerializeField] // RVA: 0x13FF30 Offset: 0x140031 VA: 0x13FF30
	protected ColorMode m_colorMode; // 0x1AC
	[SerializeField] // RVA: 0x13FF40 Offset: 0x140041 VA: 0x13FF40
	protected VertexGradient m_fontColorGradient; // 0x1B0
	[SerializeField] // RVA: 0x13FF50 Offset: 0x140051 VA: 0x13FF50
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1F0
	[SerializeField] // RVA: 0x13FF60 Offset: 0x140061 VA: 0x13FF60
	protected TMP_SpriteAsset m_spriteAsset; // 0x1F8
	[SerializeField] // RVA: 0x13FF70 Offset: 0x140071 VA: 0x13FF70
	protected bool m_tintAllSprites; // 0x200
	protected bool m_tintSprite; // 0x201
	protected Color32 m_spriteColor; // 0x204
	[SerializeField] // RVA: 0x13FF80 Offset: 0x140081 VA: 0x13FF80
	protected TMP_StyleSheet m_StyleSheet; // 0x208
	internal TMP_Style m_TextStyle; // 0x210
	[SerializeField] // RVA: 0x13FF90 Offset: 0x140091 VA: 0x13FF90
	protected int m_TextStyleHashCode; // 0x218
	[SerializeField] // RVA: 0x13FFA0 Offset: 0x1400A1 VA: 0x13FFA0
	protected bool m_overrideHtmlColors; // 0x21C
	[SerializeField] // RVA: 0x13FFB0 Offset: 0x1400B1 VA: 0x13FFB0
	protected Color32 m_faceColor; // 0x220
	protected Color32 m_outlineColor; // 0x224
	protected float m_outlineWidth; // 0x228
	[SerializeField] // RVA: 0x13FFC0 Offset: 0x1400C1 VA: 0x13FFC0
	protected float m_fontSize; // 0x22C
	protected float m_currentFontSize; // 0x230
	[SerializeField] // RVA: 0x13FFD0 Offset: 0x1400D1 VA: 0x13FFD0
	protected float m_fontSizeBase; // 0x234
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x238
	[SerializeField] // RVA: 0x13FFE0 Offset: 0x1400E1 VA: 0x13FFE0
	protected FontWeight m_fontWeight; // 0x258
	protected FontWeight m_FontWeightInternal; // 0x25C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x260
	[SerializeField] // RVA: 0x13FFF0 Offset: 0x1400F1 VA: 0x13FFF0
	protected bool m_enableAutoSizing; // 0x280
	protected float m_maxFontSize; // 0x284
	protected float m_minFontSize; // 0x288
	protected int m_AutoSizeIterationCount; // 0x28C
	protected int m_AutoSizeMaxIterationCount; // 0x290
	protected bool m_IsAutoSizePointSizeSet; // 0x294
	[SerializeField] // RVA: 0x140000 Offset: 0x140101 VA: 0x140000
	protected float m_fontSizeMin; // 0x298
	[SerializeField] // RVA: 0x140010 Offset: 0x140111 VA: 0x140010
	protected float m_fontSizeMax; // 0x29C
	[SerializeField] // RVA: 0x140020 Offset: 0x140121 VA: 0x140020
	protected FontStyles m_fontStyle; // 0x2A0
	protected FontStyles m_FontStyleInternal; // 0x2A4
	protected TMP_FontStyleStack m_fontStyleStack; // 0x2A8
	protected bool m_isUsingBold; // 0x2B2
	[SerializeField] // RVA: 0x140030 Offset: 0x140131 VA: 0x140030
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x2B4
	[SerializeField] // RVA: 0x140040 Offset: 0x140141 VA: 0x140040
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x2B8
	[SerializeField] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	[FormerlySerializedAsAttribute] // RVA: 0x140050 Offset: 0x140151 VA: 0x140050
	protected TextAlignmentOptions m_textAlignment; // 0x2BC
	protected HorizontalAlignmentOptions m_lineJustification; // 0x2C0
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2C8
	protected Vector3[] m_textContainerLocalCorners; // 0x2E8
	[SerializeField] // RVA: 0x1400A0 Offset: 0x1401A1 VA: 0x1400A0
	protected float m_characterSpacing; // 0x2F0
	protected float m_cSpacing; // 0x2F4
	protected float m_monoSpacing; // 0x2F8
	[SerializeField] // RVA: 0x1400B0 Offset: 0x1401B1 VA: 0x1400B0
	protected float m_wordSpacing; // 0x2FC
	[SerializeField] // RVA: 0x1400C0 Offset: 0x1401C1 VA: 0x1400C0
	protected float m_lineSpacing; // 0x300
	protected float m_lineSpacingDelta; // 0x304
	protected float m_lineHeight; // 0x308
	protected bool m_IsDrivenLineSpacing; // 0x30C
	[SerializeField] // RVA: 0x1400D0 Offset: 0x1401D1 VA: 0x1400D0
	protected float m_lineSpacingMax; // 0x310
	[SerializeField] // RVA: 0x1400E0 Offset: 0x1401E1 VA: 0x1400E0
	protected float m_paragraphSpacing; // 0x314
	[SerializeField] // RVA: 0x1400F0 Offset: 0x1401F1 VA: 0x1400F0
	protected float m_charWidthMaxAdj; // 0x318
	protected float m_charWidthAdjDelta; // 0x31C
	[SerializeField] // RVA: 0x140100 Offset: 0x140201 VA: 0x140100
	protected bool m_enableWordWrapping; // 0x320
	protected bool m_isCharacterWrappingEnabled; // 0x321
	protected bool m_isNonBreakingSpace; // 0x322
	protected bool m_isIgnoringAlignment; // 0x323
	[SerializeField] // RVA: 0x140110 Offset: 0x140211 VA: 0x140110
	protected float m_wordWrappingRatios; // 0x324
	[SerializeField] // RVA: 0x140120 Offset: 0x140221 VA: 0x140120
	protected TextOverflowModes m_overflowMode; // 0x328
	protected int m_firstOverflowCharacterIndex; // 0x32C
	[SerializeField] // RVA: 0x140130 Offset: 0x140231 VA: 0x140130
	protected TMP_Text m_linkedTextComponent; // 0x330
	[SerializeField] // RVA: 0x140140 Offset: 0x140241 VA: 0x140140
	internal TMP_Text parentLinkedComponent; // 0x338
	protected bool m_isTextTruncated; // 0x340
	[SerializeField] // RVA: 0x140150 Offset: 0x140251 VA: 0x140150
	protected bool m_enableKerning; // 0x341
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x344
	[SerializeField] // RVA: 0x140160 Offset: 0x140261 VA: 0x140160
	protected bool m_enableExtraPadding; // 0x348
	[SerializeField] // RVA: 0x140170 Offset: 0x140271 VA: 0x140170
	protected bool checkPaddingRequired; // 0x349
	[SerializeField] // RVA: 0x140180 Offset: 0x140281 VA: 0x140180
	protected bool m_isRichText; // 0x34A
	[SerializeField] // RVA: 0x140190 Offset: 0x140291 VA: 0x140190
	protected bool m_parseCtrlCharacters; // 0x34B
	protected bool m_isOverlay; // 0x34C
	[SerializeField] // RVA: 0x1401A0 Offset: 0x1402A1 VA: 0x1401A0
	protected bool m_isOrthographic; // 0x34D
	[SerializeField] // RVA: 0x1401B0 Offset: 0x1402B1 VA: 0x1401B0
	protected bool m_isCullingEnabled; // 0x34E
	protected bool m_isMaskingEnabled; // 0x34F
	protected bool isMaskUpdateRequired; // 0x350
	protected bool m_ignoreCulling; // 0x351
	[SerializeField] // RVA: 0x1401C0 Offset: 0x1402C1 VA: 0x1401C0
	protected TextureMappingOptions m_horizontalMapping; // 0x354
	[SerializeField] // RVA: 0x1401D0 Offset: 0x1402D1 VA: 0x1401D0
	protected TextureMappingOptions m_verticalMapping; // 0x358
	[SerializeField] // RVA: 0x1401E0 Offset: 0x1402E1 VA: 0x1401E0
	protected float m_uvLineOffset; // 0x35C
	protected TextRenderFlags m_renderMode; // 0x360
	[SerializeField] // RVA: 0x1401F0 Offset: 0x1402F1 VA: 0x1401F0
	protected VertexSortingOrder m_geometrySortingOrder; // 0x364
	[SerializeField] // RVA: 0x140200 Offset: 0x140301 VA: 0x140200
	protected bool m_IsTextObjectScaleStatic; // 0x368
	[SerializeField] // RVA: 0x140210 Offset: 0x140311 VA: 0x140210
	protected bool m_VertexBufferAutoSizeReduction; // 0x369
	protected int m_firstVisibleCharacter; // 0x36C
	protected int m_maxVisibleCharacters; // 0x370
	protected int m_maxVisibleWords; // 0x374
	protected int m_maxVisibleLines; // 0x378
	[SerializeField] // RVA: 0x140220 Offset: 0x140321 VA: 0x140220
	protected bool m_useMaxVisibleDescender; // 0x37C
	[SerializeField] // RVA: 0x140230 Offset: 0x140331 VA: 0x140230
	protected int m_pageToDisplay; // 0x380
	protected bool m_isNewPage; // 0x384
	[SerializeField] // RVA: 0x140240 Offset: 0x140341 VA: 0x140240
	protected Vector4 m_margin; // 0x388
	protected float m_marginLeft; // 0x398
	protected float m_marginRight; // 0x39C
	protected float m_marginWidth; // 0x3A0
	protected float m_marginHeight; // 0x3A4
	protected float m_width; // 0x3A8
	protected TMP_TextInfo m_textInfo; // 0x3B0
	protected bool m_havePropertiesChanged; // 0x3B8
	[SerializeField] // RVA: 0x140250 Offset: 0x140351 VA: 0x140250
	protected bool m_isUsingLegacyAnimationComponent; // 0x3B9
	protected Transform m_transform; // 0x3C0
	protected RectTransform m_rectTransform; // 0x3C8
	protected Vector2 m_PreviousRectTransformSize; // 0x3D0
	protected Vector2 m_PreviousPivotPosition; // 0x3D8
	[CompilerGeneratedAttribute] // RVA: 0x140260 Offset: 0x140361 VA: 0x140260
	private bool <autoSizeTextContainer>k__BackingField; // 0x3E0
	protected bool m_autoSizeTextContainer; // 0x3E1
	protected Mesh m_mesh; // 0x3E8
	[SerializeField] // RVA: 0x140270 Offset: 0x140371 VA: 0x140270
	protected bool m_isVolumetricText; // 0x3F0
	[CompilerGeneratedAttribute] // RVA: 0x140280 Offset: 0x140381 VA: 0x140280
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x140290 Offset: 0x140391 VA: 0x140290
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1402A0 Offset: 0x1403A1 VA: 0x1402A0
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3F8
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x400
	protected float m_flexibleHeight; // 0x408
	protected float m_flexibleWidth; // 0x40C
	protected float m_minWidth; // 0x410
	protected float m_minHeight; // 0x414
	protected float m_maxWidth; // 0x418
	protected float m_maxHeight; // 0x41C
	protected LayoutElement m_LayoutElement; // 0x420
	protected float m_preferredWidth; // 0x428
	protected float m_renderedWidth; // 0x42C
	protected bool m_isPreferredWidthDirty; // 0x430
	protected float m_preferredHeight; // 0x434
	protected float m_renderedHeight; // 0x438
	protected bool m_isPreferredHeightDirty; // 0x43C
	protected bool m_isCalculatingPreferredValues; // 0x43D
	protected int m_layoutPriority; // 0x440
	protected bool m_isLayoutDirty; // 0x444
	protected bool m_isAwake; // 0x445
	internal bool m_isWaitingOnResourceLoad; // 0x446
	internal bool m_isInputParsingRequired; // 0x447
	internal TMP_Text.TextInputSources m_inputSource; // 0x448
	protected float m_fontScale; // 0x44C
	protected float m_fontScaleMultiplier; // 0x450
	protected char[] m_htmlTag; // 0x458
	protected RichTextTagAttribute[] m_xmlAttribute; // 0x460
	protected float[] m_attributeParameterValues; // 0x468
	protected float tag_LineIndent; // 0x470
	protected float tag_Indent; // 0x474
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x478
	protected bool tag_NoParsing; // 0x498
	protected bool m_isParsingText; // 0x499
	protected Matrix4x4 m_FXMatrix; // 0x49C
	protected bool m_isFXMatrixSet; // 0x4DC
	protected TMP_Text.UnicodeChar[] m_InternalParsingBuffer; // 0x4E0
	protected int m_InternalParsingBufferSize; // 0x4E8
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x4F0
	protected char[] m_input_CharArray; // 0x4F8
	private int m_charArray_Length; // 0x500
	protected int m_totalCharacterCount; // 0x504
	protected WordWrapState m_SavedWordWrapState; // 0x508
	protected WordWrapState m_SavedLineState; // 0x880
	protected WordWrapState m_SavedEllipsisState; // 0xBF8
	protected WordWrapState m_SavedLastValidState; // 0xF70
	protected WordWrapState m_SavedSoftLineBreakState; // 0x12E8
	internal TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1660
	protected int m_characterCount; // 0x19F8
	protected int m_firstCharacterOfLine; // 0x19FC
	protected int m_firstVisibleCharacterOfLine; // 0x1A00
	protected int m_lastCharacterOfLine; // 0x1A04
	protected int m_lastVisibleCharacterOfLine; // 0x1A08
	protected int m_lineNumber; // 0x1A0C
	protected int m_lineVisibleCharacterCount; // 0x1A10
	protected int m_pageNumber; // 0x1A14
	protected float m_PageAscender; // 0x1A18
	protected float m_maxTextAscender; // 0x1A1C
	protected float m_maxCapHeight; // 0x1A20
	protected float m_ElementAscender; // 0x1A24
	protected float m_ElementDescender; // 0x1A28
	protected float m_maxLineAscender; // 0x1A2C
	protected float m_maxLineDescender; // 0x1A30
	protected float m_startOfLineAscender; // 0x1A34
	protected float m_startOfLineDescender; // 0x1A38
	protected float m_lineOffset; // 0x1A3C
	protected Extents m_meshExtents; // 0x1A40
	protected Color32 m_htmlColor; // 0x1A50
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x1A58
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x1A78
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x1A98
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x1AB8
	protected TMP_ColorGradient m_colorGradientPreset; // 0x1AE8
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x1AF0
	protected bool m_colorGradientPresetIsTinted; // 0x1B18
	protected float m_tabSpacing; // 0x1B1C
	protected float m_spacing; // 0x1B20
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x1B28
	protected int m_TextStyleStackDepth; // 0x1B30
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x1B38
	protected int m_ItalicAngle; // 0x1B58
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x1B60
	protected float m_padding; // 0x1B80
	protected float m_baselineOffset; // 0x1B84
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x1B88
	protected float m_xAdvance; // 0x1BA8
	protected TMP_TextElementType m_textElementType; // 0x1BAC
	protected TMP_TextElement m_cached_TextElement; // 0x1BB0
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x1BB8
	protected TMP_Text.SpecialCharacter m_Underline; // 0x1BD8
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x1BF8
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x1C00
	protected int m_spriteCount; // 0x1C08
	protected int m_spriteIndex; // 0x1C0C
	protected int m_spriteAnimationID; // 0x1C10
	protected bool m_ignoreActiveState; // 0x1C14
	private readonly Decimal[] k_Power; // 0x1C18
	protected static Vector2 k_LargePositiveVector2; // 0x18
	protected static Vector2 k_LargeNegativeVector2; // 0x20
	protected static float k_LargePositiveFloat; // 0x28
	protected static float k_LargeNegativeFloat; // 0x2C
	protected static int k_LargePositiveInt; // 0x30
	protected static int k_LargeNegativeInt; // 0x34

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public float fontScale { get; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x14CDCA0 Offset: 0x14CDDA1 VA: 0x14CDCA0 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x14CDCB0 Offset: 0x14CDDB1 VA: 0x14CDCB0 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x14CDD60 Offset: 0x14CDE61 VA: 0x14CDD60
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x14CDD70 Offset: 0x14CDE71 VA: 0x14CDD70
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x14CDD80 Offset: 0x14CDE81 VA: 0x14CDD80
	public bool get_isRightToLeftText() { }

	// RVA: 0x14CDD90 Offset: 0x14CDE91 VA: 0x14CDD90
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x14CDE00 Offset: 0x14CDF01 VA: 0x14CDE00
	public TMP_FontAsset get_font() { }

	// RVA: 0x14CDE10 Offset: 0x14CDF11 VA: 0x14CDE10
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x14CDF00 Offset: 0x14CE001 VA: 0x14CDF00 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x14CDF10 Offset: 0x14CE011 VA: 0x14CDF10 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x14CDFF0 Offset: 0x14CE0F1 VA: 0x14CDFF0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x14CE000 Offset: 0x14CE101 VA: 0x14CE000 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x14CE060 Offset: 0x14CE161 VA: 0x14CE060
	public Material get_fontMaterial() { }

	// RVA: 0x14CE080 Offset: 0x14CE181 VA: 0x14CE080
	public void set_fontMaterial(Material value) { }

	// RVA: 0x14CE1A0 Offset: 0x14CE2A1 VA: 0x14CE1A0 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x14CE1C0 Offset: 0x14CE2C1 VA: 0x14CE1C0 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x14CE220 Offset: 0x14CE321 VA: 0x14CE220 Slot: 22
	public override Color get_color() { }

	// RVA: 0x14CE240 Offset: 0x14CE341 VA: 0x14CE240 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x14CE2F0 Offset: 0x14CE3F1 VA: 0x14CE2F0
	public float get_alpha() { }

	// RVA: 0x14CE300 Offset: 0x14CE401 VA: 0x14CE300
	public void set_alpha(float value) { }

	// RVA: 0x14CE330 Offset: 0x14CE431 VA: 0x14CE330
	public bool get_enableVertexGradient() { }

	// RVA: 0x14CE340 Offset: 0x14CE441 VA: 0x14CE340
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x14CE380 Offset: 0x14CE481 VA: 0x14CE380
	public VertexGradient get_colorGradient() { }

	// RVA: 0x14CE3B0 Offset: 0x14CE4B1 VA: 0x14CE3B0
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x14CE3F0 Offset: 0x14CE4F1 VA: 0x14CE3F0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x14CE400 Offset: 0x14CE501 VA: 0x14CE400
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x14CE440 Offset: 0x14CE541 VA: 0x14CE440
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x14CE450 Offset: 0x14CE551 VA: 0x14CE450
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x14CE4B0 Offset: 0x14CE5B1 VA: 0x14CE4B0
	public bool get_tintAllSprites() { }

	// RVA: 0x14CE4C0 Offset: 0x14CE5C1 VA: 0x14CE4C0
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x14CE500 Offset: 0x14CE601 VA: 0x14CE500
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x14CE510 Offset: 0x14CE611 VA: 0x14CE510
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x14CE570 Offset: 0x14CE671 VA: 0x14CE570
	public TMP_Style get_textStyle() { }

	// RVA: 0x14CE830 Offset: 0x14CE931 VA: 0x14CE830
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x14CE8A0 Offset: 0x14CE9A1 VA: 0x14CE8A0
	public bool get_overrideColorTags() { }

	// RVA: 0x14CE8B0 Offset: 0x14CE9B1 VA: 0x14CE8B0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x14CE8F0 Offset: 0x14CE9F1 VA: 0x14CE8F0
	public Color32 get_faceColor() { }

	// RVA: 0x14CE9E0 Offset: 0x14CEAE1 VA: 0x14CE9E0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x14CEA80 Offset: 0x14CEB81 VA: 0x14CEA80
	public Color32 get_outlineColor() { }

	// RVA: 0x14CEB70 Offset: 0x14CEC71 VA: 0x14CEB70
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x14CEC00 Offset: 0x14CED01 VA: 0x14CEC00
	public float get_outlineWidth() { }

	// RVA: 0x14CECE0 Offset: 0x14CEDE1 VA: 0x14CECE0
	public void set_outlineWidth(float value) { }

	// RVA: 0x14CED60 Offset: 0x14CEE61 VA: 0x14CED60
	public float get_fontSize() { }

	// RVA: 0x14CED70 Offset: 0x14CEE71 VA: 0x14CED70
	public void set_fontSize(float value) { }

	// RVA: 0x14CEDE0 Offset: 0x14CEEE1 VA: 0x14CEDE0
	public float get_fontScale() { }

	// RVA: 0x14CEDF0 Offset: 0x14CEEF1 VA: 0x14CEDF0
	public FontWeight get_fontWeight() { }

	// RVA: 0x14CEE00 Offset: 0x14CEF01 VA: 0x14CEE00
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x14CEE60 Offset: 0x14CEF61 VA: 0x14CEE60
	public float get_pixelsPerUnit() { }

	// RVA: 0x14CF010 Offset: 0x14CF111 VA: 0x14CF010
	public bool get_enableAutoSizing() { }

	// RVA: 0x14CF020 Offset: 0x14CF121 VA: 0x14CF020
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x14CF080 Offset: 0x14CF181 VA: 0x14CF080
	public float get_fontSizeMin() { }

	// RVA: 0x14CF090 Offset: 0x14CF191 VA: 0x14CF090
	public void set_fontSizeMin(float value) { }

	// RVA: 0x14CF0E0 Offset: 0x14CF1E1 VA: 0x14CF0E0
	public float get_fontSizeMax() { }

	// RVA: 0x14CF0F0 Offset: 0x14CF1F1 VA: 0x14CF0F0
	public void set_fontSizeMax(float value) { }

	// RVA: 0x14CF140 Offset: 0x14CF241 VA: 0x14CF140
	public FontStyles get_fontStyle() { }

	// RVA: 0x14CF150 Offset: 0x14CF251 VA: 0x14CF150
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x14CF1B0 Offset: 0x14CF2B1 VA: 0x14CF1B0
	public bool get_isUsingBold() { }

	// RVA: 0x14CF1C0 Offset: 0x14CF2C1 VA: 0x14CF1C0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x14CF1D0 Offset: 0x14CF2D1 VA: 0x14CF1D0
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x14CF200 Offset: 0x14CF301 VA: 0x14CF200
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x14CF210 Offset: 0x14CF311 VA: 0x14CF210
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x14CF240 Offset: 0x14CF341 VA: 0x14CF240
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x14CF250 Offset: 0x14CF351 VA: 0x14CF250
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x14CF2A0 Offset: 0x14CF3A1 VA: 0x14CF2A0
	public float get_characterSpacing() { }

	// RVA: 0x14CF2B0 Offset: 0x14CF3B1 VA: 0x14CF2B0
	public void set_characterSpacing(float value) { }

	// RVA: 0x14CF310 Offset: 0x14CF411 VA: 0x14CF310
	public float get_wordSpacing() { }

	// RVA: 0x14CF320 Offset: 0x14CF421 VA: 0x14CF320
	public void set_wordSpacing(float value) { }

	// RVA: 0x14CF380 Offset: 0x14CF481 VA: 0x14CF380
	public float get_lineSpacing() { }

	// RVA: 0x14CF390 Offset: 0x14CF491 VA: 0x14CF390
	public void set_lineSpacing(float value) { }

	// RVA: 0x14CF3F0 Offset: 0x14CF4F1 VA: 0x14CF3F0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x14CF400 Offset: 0x14CF501 VA: 0x14CF400
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x14CF460 Offset: 0x14CF561 VA: 0x14CF460
	public float get_paragraphSpacing() { }

	// RVA: 0x14CF470 Offset: 0x14CF571 VA: 0x14CF470
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x14CF4D0 Offset: 0x14CF5D1 VA: 0x14CF4D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x14CF4E0 Offset: 0x14CF5E1 VA: 0x14CF4E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x14CF540 Offset: 0x14CF641 VA: 0x14CF540
	public bool get_enableWordWrapping() { }

	// RVA: 0x14CF550 Offset: 0x14CF651 VA: 0x14CF550
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x14CF5C0 Offset: 0x14CF6C1 VA: 0x14CF5C0
	public float get_wordWrappingRatios() { }

	// RVA: 0x14CF5D0 Offset: 0x14CF6D1 VA: 0x14CF5D0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x14CF630 Offset: 0x14CF731 VA: 0x14CF630
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x14CF640 Offset: 0x14CF741 VA: 0x14CF640
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x14CF6A0 Offset: 0x14CF7A1 VA: 0x14CF6A0
	public bool get_isTextOverflowing() { }

	// RVA: 0x14CF6B0 Offset: 0x14CF7B1 VA: 0x14CF6B0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x14CF6C0 Offset: 0x14CF7C1 VA: 0x14CF6C0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x14CF6D0 Offset: 0x14CF7D1 VA: 0x14CF6D0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x14CFA50 Offset: 0x14CFB51 VA: 0x14CFA50
	public bool get_isTextTruncated() { }

	// RVA: 0x14CFA60 Offset: 0x14CFB61 VA: 0x14CFA60
	public bool get_enableKerning() { }

	// RVA: 0x14CFA70 Offset: 0x14CFB71 VA: 0x14CFA70
	public void set_enableKerning(bool value) { }

	// RVA: 0x14CFAE0 Offset: 0x14CFBE1 VA: 0x14CFAE0
	public bool get_extraPadding() { }

	// RVA: 0x14CFAF0 Offset: 0x14CFBF1 VA: 0x14CFAF0
	public void set_extraPadding(bool value) { }

	// RVA: 0x14CFB60 Offset: 0x14CFC61 VA: 0x14CFB60
	public bool get_richText() { }

	// RVA: 0x14CFB70 Offset: 0x14CFC71 VA: 0x14CFB70
	public void set_richText(bool value) { }

	// RVA: 0x14CFBE0 Offset: 0x14CFCE1 VA: 0x14CFBE0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x14CFBF0 Offset: 0x14CFCF1 VA: 0x14CFBF0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x14CFC60 Offset: 0x14CFD61 VA: 0x14CFC60
	public bool get_isOverlay() { }

	// RVA: 0x14CFC70 Offset: 0x14CFD71 VA: 0x14CFC70
	public void set_isOverlay(bool value) { }

	// RVA: 0x14CFCE0 Offset: 0x14CFDE1 VA: 0x14CFCE0
	public bool get_isOrthographic() { }

	// RVA: 0x14CFCF0 Offset: 0x14CFDF1 VA: 0x14CFCF0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x14CFD30 Offset: 0x14CFE31 VA: 0x14CFD30
	public bool get_enableCulling() { }

	// RVA: 0x14CFD40 Offset: 0x14CFE41 VA: 0x14CFD40
	public void set_enableCulling(bool value) { }

	// RVA: 0x14CFD90 Offset: 0x14CFE91 VA: 0x14CFD90
	public bool get_ignoreVisibility() { }

	// RVA: 0x14CFDA0 Offset: 0x14CFEA1 VA: 0x14CFDA0
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x14CFDD0 Offset: 0x14CFED1 VA: 0x14CFDD0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x14CFDE0 Offset: 0x14CFEE1 VA: 0x14CFDE0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE10 Offset: 0x14CFF11 VA: 0x14CFE10
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x14CFE20 Offset: 0x14CFF21 VA: 0x14CFE20
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x14CFE50 Offset: 0x14CFF51 VA: 0x14CFE50
	public float get_mappingUvLineOffset() { }

	// RVA: 0x14CFE60 Offset: 0x14CFF61 VA: 0x14CFE60
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x14CFE90 Offset: 0x14CFF91 VA: 0x14CFE90
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x14CFEA0 Offset: 0x14CFFA1 VA: 0x14CFEA0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x14CFEC0 Offset: 0x14CFFC1 VA: 0x14CFEC0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x14CFED0 Offset: 0x14CFFD1 VA: 0x14CFED0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x14CFEF0 Offset: 0x14CFFF1 VA: 0x14CFEF0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x14CFF00 Offset: 0x14D0001 VA: 0x14CFF00
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x14CFF20 Offset: 0x14D0021 VA: 0x14CFF20
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x14CFF30 Offset: 0x14D0031 VA: 0x14CFF30
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x14CFF50 Offset: 0x14D0051 VA: 0x14CFF50
	public int get_firstVisibleCharacter() { }

	// RVA: 0x14CFF60 Offset: 0x14D0061 VA: 0x14CFF60
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x14CFF90 Offset: 0x14D0091 VA: 0x14CFF90
	public int get_maxVisibleCharacters() { }

	// RVA: 0x14CFFA0 Offset: 0x14D00A1 VA: 0x14CFFA0
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x14CFFD0 Offset: 0x14D00D1 VA: 0x14CFFD0
	public int get_maxVisibleWords() { }

	// RVA: 0x14CFFE0 Offset: 0x14D00E1 VA: 0x14CFFE0
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x14D0010 Offset: 0x14D0111 VA: 0x14D0010
	public int get_maxVisibleLines() { }

	// RVA: 0x14D0020 Offset: 0x14D0121 VA: 0x14D0020
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x14D0050 Offset: 0x14D0151 VA: 0x14D0050
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x14D0060 Offset: 0x14D0161 VA: 0x14D0060
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x14D00A0 Offset: 0x14D01A1 VA: 0x14D00A0
	public int get_pageToDisplay() { }

	// RVA: 0x14D00B0 Offset: 0x14D01B1 VA: 0x14D00B0
	public void set_pageToDisplay(int value) { }

	// RVA: 0x14D00E0 Offset: 0x14D01E1 VA: 0x14D00E0 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x14D0100 Offset: 0x14D0201 VA: 0x14D0100 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x14D0230 Offset: 0x14D0331 VA: 0x14D0230
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x14D0240 Offset: 0x14D0341 VA: 0x14D0240
	public bool get_havePropertiesChanged() { }

	// RVA: 0x14CBB20 Offset: 0x14CBC21 VA: 0x14CBB20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x14D0250 Offset: 0x14D0351 VA: 0x14D0250
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x14D0260 Offset: 0x14D0361 VA: 0x14D0260
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x14CCE50 Offset: 0x14CCF51 VA: 0x14CCE50
	public Transform get_transform() { }

	// RVA: 0x14CCF00 Offset: 0x14CD001 VA: 0x14CCF00
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x140690 Offset: 0x140791 VA: 0x140690
	// RVA: 0x14D0270 Offset: 0x14D0371 VA: 0x14D0270 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406A0 Offset: 0x1407A1 VA: 0x1406A0
	// RVA: 0x14D0280 Offset: 0x14D0381 VA: 0x14D0280 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x14D0290 Offset: 0x14D0391 VA: 0x14D0290 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x14D02A0 Offset: 0x14D03A1 VA: 0x14D02A0
	public bool get_isVolumetricText() { }

	// RVA: 0x14D02B0 Offset: 0x14D03B1 VA: 0x14D02B0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x14D0340 Offset: 0x14D0441 VA: 0x14D0340
	public Bounds get_bounds() { }

	// RVA: 0x14D03F0 Offset: 0x14D04F1 VA: 0x14D03F0
	public Bounds get_textBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x1406B0 Offset: 0x1407B1 VA: 0x1406B0
	// RVA: 0x14D06D0 Offset: 0x14D07D1 VA: 0x14D06D0
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406C0 Offset: 0x1407C1 VA: 0x1406C0
	// RVA: 0x14D07C0 Offset: 0x14D08C1 VA: 0x14D07C0
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406D0 Offset: 0x1407D1 VA: 0x1406D0
	// RVA: 0x14D08B0 Offset: 0x14D09B1 VA: 0x14D08B0
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406E0 Offset: 0x1407E1 VA: 0x1406E0
	// RVA: 0x14D09A0 Offset: 0x14D0AA1 VA: 0x14D09A0
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1406F0 Offset: 0x1407F1 VA: 0x1406F0
	// RVA: 0x14D0A90 Offset: 0x14D0B91 VA: 0x14D0A90 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140700 Offset: 0x140801 VA: 0x140700
	// RVA: 0x14D0B40 Offset: 0x14D0C41 VA: 0x14D0B40 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x14D0BF0 Offset: 0x14D0CF1 VA: 0x14D0BF0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x14D0D00 Offset: 0x14D0E01 VA: 0x14D0D00 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x14D0D10 Offset: 0x14D0E11 VA: 0x14D0D10 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x14D0D20 Offset: 0x14D0E21 VA: 0x14D0D20 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x14D0D30 Offset: 0x14D0E31 VA: 0x14D0D30 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x14D0D40 Offset: 0x14D0E41 VA: 0x14D0D40
	public float get_maxWidth() { }

	// RVA: 0x14D0D50 Offset: 0x14D0E51 VA: 0x14D0D50
	public float get_maxHeight() { }

	// RVA: 0x14D0D60 Offset: 0x14D0E61 VA: 0x14D0D60
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x14D0E10 Offset: 0x14D0F11 VA: 0x14D0E10 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x14D0FB0 Offset: 0x14D10B1 VA: 0x14D0FB0 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x14D1190 Offset: 0x14D1291 VA: 0x14D1190 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x14D11B0 Offset: 0x14D12B1 VA: 0x14D11B0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x14D11F0 Offset: 0x14D12F1 VA: 0x14D11F0 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x14D1200 Offset: 0x14D1301 VA: 0x14D1200 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x14D1210 Offset: 0x14D1311 VA: 0x14D1210 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x14D1220 Offset: 0x14D1321 VA: 0x14D1220 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x14D1230 Offset: 0x14D1331 VA: 0x14D1230 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x14D1240 Offset: 0x14D1341 VA: 0x14D1240 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x14D1250 Offset: 0x14D1351 VA: 0x14D1250 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x14D1260 Offset: 0x14D1361 VA: 0x14D1260 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x14D1270 Offset: 0x14D1371 VA: 0x14D1270 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x14D1330 Offset: 0x14D1431 VA: 0x14D1330
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x14D1430 Offset: 0x14D1531 VA: 0x14D1430
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x14D1440 Offset: 0x14D1541 VA: 0x14D1440
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x14D1450 Offset: 0x14D1551 VA: 0x14D1450 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x14D1460 Offset: 0x14D1561 VA: 0x14D1460 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x14D1470 Offset: 0x14D1571 VA: 0x14D1470 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x14D1480 Offset: 0x14D1581 VA: 0x14D1480 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x14D1490 Offset: 0x14D1591 VA: 0x14D1490 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x14D14A0 Offset: 0x14D15A1 VA: 0x14D14A0 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x14D14B0 Offset: 0x14D15B1 VA: 0x14D14B0 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x14D15F0 Offset: 0x14D16F1 VA: 0x14D15F0 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x14D1710 Offset: 0x14D1811 VA: 0x14D1710 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x14D1720 Offset: 0x14D1821 VA: 0x14D1720 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x14D1730 Offset: 0x14D1831 VA: 0x14D1730
	internal void SetTextInternal(string text) { }

	// RVA: 0x14D1790 Offset: 0x14D1891 VA: 0x14D1790 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x14D17A0 Offset: 0x14D18A1 VA: 0x14D17A0 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x14D17B0 Offset: 0x14D18B1 VA: 0x14D17B0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x14D17C0 Offset: 0x14D18C1 VA: 0x14D17C0 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x14D17D0 Offset: 0x14D18D1 VA: 0x14D17D0 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x14D17E0 Offset: 0x14D18E1 VA: 0x14D17E0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D1880 Offset: 0x14D1981 VA: 0x14D1880 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D18E0 Offset: 0x14D19E1 VA: 0x14D18E0 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x14D18F0 Offset: 0x14D19F1 VA: 0x14D18F0 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x14D1900 Offset: 0x14D1A01 VA: 0x14D1900
	protected void ParseInputText() { }

	// RVA: 0x14D2CD0 Offset: 0x14D2DD1 VA: 0x14D2CD0
	public void SetText(string text, bool syncTextInputBox = True) { }

	// RVA: 0x14D2CE0 Offset: 0x14D2DE1 VA: 0x14D2CE0
	public void SetText(string text, float arg0) { }

	// RVA: 0x14D2FF0 Offset: 0x14D30F1 VA: 0x14D2FF0
	public void SetText(string text, float arg0, float arg1) { }

	// RVA: 0x14D3010 Offset: 0x14D3111 VA: 0x14D3010
	public void SetText(string text, float arg0, float arg1, float arg2) { }

	// RVA: 0x14D3030 Offset: 0x14D3131 VA: 0x14D3030
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x14D3050 Offset: 0x14D3151 VA: 0x14D3050
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x14D3060 Offset: 0x14D3161 VA: 0x14D3060
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x14D3070 Offset: 0x14D3171 VA: 0x14D3070
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x14D2D00 Offset: 0x14D2E01 VA: 0x14D2D00
	public void SetText(string text, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x14D33D0 Offset: 0x14D34D1 VA: 0x14D33D0
	public void SetText(StringBuilder text) { }

	// RVA: 0x14D3DD0 Offset: 0x14D3ED1 VA: 0x14D3DD0
	public void SetText(char[] text) { }

	// RVA: 0x14D4460 Offset: 0x14D4561 VA: 0x14D4460
	public void SetText(char[] text, int start, int length) { }

	// RVA: 0x14D3DE0 Offset: 0x14D3EE1 VA: 0x14D3DE0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x14D4470 Offset: 0x14D4571 VA: 0x14D4470
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x14D5E70 Offset: 0x14D5F71 VA: 0x14D5E70
	public void SetCharArray(int[] sourceText, int start, int length) { }

	// RVA: 0x14D2640 Offset: 0x14D2741 VA: 0x14D2640
	protected int CharArrayToInternalParsingBuffer(char[] sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D1A30 Offset: 0x14D1B31 VA: 0x14D1A30
	protected int StringToInternalParsingBuffer(string sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D3430 Offset: 0x14D3531 VA: 0x14D3430
	protected int StringBuilderToInternalParsingBuffer(StringBuilder sourceText, ref TMP_Text.UnicodeChar[] internalParsingArray) { }

	// RVA: 0x14D7240 Offset: 0x14D7341 VA: 0x14D7240
	private bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D65F0 Offset: 0x14D66F1 VA: 0x14D65F0
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D50E0 Offset: 0x14D51E1 VA: 0x14D50E0
	private bool ReplaceOpeningStyleTag(ref char[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7E90 Offset: 0x14D7F91 VA: 0x14D7E90
	private bool ReplaceOpeningStyleTag(ref StringBuilder sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D76F0 Offset: 0x14D77F1 VA: 0x14D76F0
	private bool ReplaceClosingStyleTag(ref string sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D6AA0 Offset: 0x14D6BA1 VA: 0x14D6AA0
	private bool ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5590 Offset: 0x14D5691 VA: 0x14D5590
	private bool ReplaceClosingStyleTag(ref char[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D8330 Offset: 0x14D8431 VA: 0x14D8330
	private bool ReplaceClosingStyleTag(ref StringBuilder sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14CE670 Offset: 0x14CE771 VA: 0x14CE670
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x14D4B50 Offset: 0x14D4C51 VA: 0x14D4B50
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D5A10 Offset: 0x14D5B11 VA: 0x14D5A10
	private bool InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x14D7130 Offset: 0x14D7231 VA: 0x14D7130
	private bool IsTagName(ref string text, string tag, int index) { }

	// RVA: 0x14D4FB0 Offset: 0x14D50B1 VA: 0x14D4FB0
	private bool IsTagName(ref char[] text, string tag, int index) { }

	// RVA: 0x14D64C0 Offset: 0x14D65C1 VA: 0x14D64C0
	private bool IsTagName(ref int[] text, string tag, int index) { }

	// RVA: 0x14D7D80 Offset: 0x14D7E81 VA: 0x14D7D80
	private bool IsTagName(ref StringBuilder text, string tag, int index) { }

	// RVA: 0x14D87B0 Offset: 0x14D88B1 VA: 0x14D87B0
	private int GetTagHashCode(ref string text, int index, out int closeIndex) { }

	// RVA: 0x14D8BE0 Offset: 0x14D8CE1 VA: 0x14D8BE0
	private int GetTagHashCode(ref char[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8AE0 Offset: 0x14D8BE1 VA: 0x14D8AE0
	private int GetTagHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x14D8CE0 Offset: 0x14D8DE1 VA: 0x14D8CE0
	private int GetTagHashCode(ref StringBuilder text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1B90 Offset: 0x23E1C91 VA: 0x23E1B90
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1CC0 Offset: 0x23E1DC1 VA: 0x23E1CC0
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1C30 Offset: 0x23E1D31 VA: 0x23E1C30
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x23E1D60 Offset: 0x23E1E61 VA: 0x23E1D60
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x14D3080 Offset: 0x14D3181 VA: 0x14D3080
	private void AddFloatToCharArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x14D8E00 Offset: 0x14D8F01 VA: 0x14D8E00
	private void AddIntegerToCharArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x14D8F60 Offset: 0x14D9061 VA: 0x14D8F60 Slot: 114
	protected virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x14D8F70 Offset: 0x14D9071 VA: 0x14D8F70 Slot: 115
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x14D8F80 Offset: 0x14D9081 VA: 0x14D8F80
	public Vector2 GetPreferredValues() { }

	// RVA: 0x14D9000 Offset: 0x14D9101 VA: 0x14D9000
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x14D9290 Offset: 0x14D9391 VA: 0x14D9290
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x14D9440 Offset: 0x14D9541 VA: 0x14D9440
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x14D0E40 Offset: 0x14D0F41 VA: 0x14D0E40
	protected float GetPreferredWidth() { }

	// RVA: 0x14D9170 Offset: 0x14D9271 VA: 0x14D9170
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x14D0FE0 Offset: 0x14D10E1 VA: 0x14D0FE0
	protected float GetPreferredHeight() { }

	// RVA: 0x14D91E0 Offset: 0x14D92E1 VA: 0x14D91E0
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x14D95C0 Offset: 0x14D96C1 VA: 0x14D95C0
	public Vector2 GetRenderedValues() { }

	// RVA: 0x14D9690 Offset: 0x14D9791 VA: 0x14D9690
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11A0 Offset: 0x14D12A1 VA: 0x14D11A0
	private float GetRenderedWidth() { }

	// RVA: 0x14D9A90 Offset: 0x14D9B91 VA: 0x14D9A90
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x14D11D0 Offset: 0x14D12D1 VA: 0x14D11D0
	private float GetRenderedHeight() { }

	// RVA: 0x14D9AA0 Offset: 0x14D9BA1 VA: 0x14D9AA0
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x14D9AC0 Offset: 0x14D9BC1 VA: 0x14D9AC0 Slot: 116
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x14E17A0 Offset: 0x14E18A1 VA: 0x14E17A0 Slot: 117
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x14E17B0 Offset: 0x14E18B1 VA: 0x14E17B0 Slot: 118
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x14D0410 Offset: 0x14D0511 VA: 0x14D0410
	protected Bounds GetTextBounds() { }

	// RVA: 0x14D9770 Offset: 0x14D9871 VA: 0x14D9770
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x14E17C0 Offset: 0x14E18C1 VA: 0x14E17C0
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x14E1BE0 Offset: 0x14E1CE1 VA: 0x14E1BE0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x14E1E70 Offset: 0x14E1F71 VA: 0x14E1E70 Slot: 119
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x14E1E80 Offset: 0x14E1F81 VA: 0x14E1E80 Slot: 120
	public virtual void ComputeMarginSize() { }

	// RVA: 0x14E1E90 Offset: 0x14E1F91 VA: 0x14E1E90
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x14E1390 Offset: 0x14E1491 VA: 0x14E1390
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x14E0EE0 Offset: 0x14E0FE1 VA: 0x14E0EE0
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x14E2580 Offset: 0x14E2681 VA: 0x14E2580 Slot: 121
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x14E30E0 Offset: 0x14E31E1 VA: 0x14E30E0 Slot: 122
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x14E38B0 Offset: 0x14E39B1 VA: 0x14E38B0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E4000 Offset: 0x14E4101 VA: 0x14E4000 Slot: 124
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x14E4F20 Offset: 0x14E5021 VA: 0x14E4F20 Slot: 125
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x14E5670 Offset: 0x14E5771 VA: 0x14E5670 Slot: 126
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x14E68A0 Offset: 0x14E69A1 VA: 0x14E68A0 Slot: 127
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x14E6E20 Offset: 0x14E6F21 VA: 0x14E6E20
	protected void LoadDefaultSettings() { }

	// RVA: 0x14E71E0 Offset: 0x14E72E1 VA: 0x14E71E0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7210 Offset: 0x14E7311 VA: 0x14E7210
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E6700 Offset: 0x14E6801 VA: 0x14E6700
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x14E7490 Offset: 0x14E7591 VA: 0x14E7490
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x14E7520 Offset: 0x14E7621 VA: 0x14E7520
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x14E75B0 Offset: 0x14E76B1 VA: 0x14E75B0
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x14E79C0 Offset: 0x14E7AC1 VA: 0x14E79C0 Slot: 128
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x14E79D0 Offset: 0x14E7AD1 VA: 0x14E79D0 Slot: 129
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x14E79E0 Offset: 0x14E7AE1 VA: 0x14E79E0 Slot: 130
	public virtual void ClearMesh() { }

	// RVA: 0x14E79F0 Offset: 0x14E7AF1 VA: 0x14E79F0 Slot: 131
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x14E7A00 Offset: 0x14E7B01 VA: 0x14E7A00 Slot: 132
	public virtual string GetParsedText() { }

	// RVA: 0x14CF940 Offset: 0x14CFA41 VA: 0x14CF940
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x14CF800 Offset: 0x14CF901 VA: 0x14CF800
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x14E6860 Offset: 0x14E6961 VA: 0x14E6860
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x14E7B20 Offset: 0x14E7C21 VA: 0x14E7B20
	protected float PackUV(float x, float y) { }

	// RVA: 0x14E7B60 Offset: 0x14E7C61 VA: 0x14E7B60 Slot: 133
	internal virtual void InternalUpdate() { }

	// RVA: 0x14E7B70 Offset: 0x14E7C71 VA: 0x14E7B70
	protected int HexToInt(char hex) { }

	// RVA: 0x14D7070 Offset: 0x14D7171 VA: 0x14D7070
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x14D88D0 Offset: 0x14D89D1 VA: 0x14D88D0
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x14D7CC0 Offset: 0x14D7DC1 VA: 0x14D7CC0
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x14D6F20 Offset: 0x14D7021 VA: 0x14D6F20
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x14D8990 Offset: 0x14D8A91 VA: 0x14D8990
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x14D7B70 Offset: 0x14D7C71 VA: 0x14D7B70
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x14E7BA0 Offset: 0x14E7CA1 VA: 0x14E7BA0
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x14E8000 Offset: 0x14E8101 VA: 0x14E8000
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x14E8290 Offset: 0x14E8391 VA: 0x14E8290
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x14E8540 Offset: 0x14E8641 VA: 0x14E8540
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x14E8350 Offset: 0x14E8451 VA: 0x14E8350
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x14DC210 Offset: 0x14DC311 VA: 0x14DC210
	protected bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x14E8570 Offset: 0x14E8671 VA: 0x14E8570
	protected void .ctor() { }

	// RVA: 0x14E9110 Offset: 0x14E9211 VA: 0x14E9110
	private static void .cctor() { }
}


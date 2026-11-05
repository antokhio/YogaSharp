using System;

namespace YogaSharp;

public unsafe struct YGNode : IDisposable
{
    /// <inheritdoc cref="Interop.YGNodeNew()"/>
    public static YGNode* New()
    {
        return Interop.YGNodeNew();
    }

    /// <inheritdoc cref="Interop.YGNodeNewWithConfig(YGConfig*)"/>
    public static YGNode* New(YGConfig* config)
    {
        return Interop.YGNodeNewWithConfig(config);
    }

    /// <inheritdoc cref="Interop.YGNodeFree(YGNode*)"/>
    public void Dispose()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeFree(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeFinalize(YGNode*)"/>
    public void FinalizeNode()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeFinalize(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeFreeRecursive(YGNode*)"/>
    public void FreeRecursive()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeFreeRecursive(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeClone(YGNode*)"/>
    public YGNode* Clone()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeClone(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeReset(YGNode*)"/>
    public void Reset()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeReset(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeCalculateLayout(YGNode*, float, float, YGDirection)"/>
    public void CalculateLayout(float ownerWidth = float.NaN, float ownerHeight = float.NaN, YGDirection ownerDirection = YGDirection.LTR)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeCalculateLayout(ptr, ownerWidth, ownerHeight, ownerDirection);
    }

    /// <inheritdoc cref="Interop.YGNodeGetHasNewLayout(YGNode*)"/>
    public bool GetHasNewLayout()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetHasNewLayout(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetHasNewLayout(YGNode*, bool)"/>
    public void SetHasNewLayout(bool hasNewLayout)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetHasNewLayout(ptr, hasNewLayout);
    }

    /// <inheritdoc cref="Interop.YGNodeIsDirty(YGNode*)"/>
    public bool IsDirty()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeIsDirty(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeMarkDirty(YGNode*)"/>
    public void MarkDirty()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeMarkDirty(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeInsertChild(YGNode*, YGNode*, int)"/>
    public void InsertChild(YGNode* child, int index)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeInsertChild(ptr, child, index);
    }

    /// <inheritdoc cref="Interop.YGNodeSwapChild(YGNode*, YGNode*, int)"/>
    public void SwapChild(YGNode* child, int index)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSwapChild(ptr, child, index);
    }

    /// <inheritdoc cref="Interop.YGNodeRemoveChild(YGNode*, YGNode*)"/>
    public void RemoveChild(YGNode* excludedChild)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeRemoveChild(ptr, excludedChild);
    }

    /// <inheritdoc cref="Interop.YGNodeRemoveAllChildren(YGNode*)"/>
    public void RemoveAllChildren()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeRemoveAllChildren(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetChildren(YGNode*, YGNode**, int)"/>
    public unsafe void SetChildren(params YGNode*[] children)
    {
        var count = children.Length;

        var childRefs = stackalloc YGNode*[count];
        for (var i = 0; i < children.Length; i++)
            childRefs[i] = children[i];

        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetChildren(ptr, childRefs, count);
    }

    /// <inheritdoc cref="Interop.YGNodeGetChild(YGNode*, int)"/>
    public YGNode* GetChild(int index)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetChild(ptr, index);
    }

    /// <inheritdoc cref="Interop.YGNodeGetChildCount(YGNode*)"/>
    public int GetChildCount()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetChildCount(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeGetOwner(YGNode*)"/>
    public YGNode* GetOwner()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetOwner(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetConfig(YGNode*, YGConfig*)"/>
    public void SetConfig(YGConfig* config)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetConfig(ptr, config);
    }

    /// <inheritdoc cref="Interop.YGNodeGetConfig(YGNode*)"/>
    public YGConfig* GetConfig()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetConfig(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetContext(YGNode*, void*)"/>
    public void SetContext(void* context)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetContext(ptr, context);
    }

    /// <inheritdoc cref="Interop.YGNodeGetContext(YGNode*)"/>
    public void* GetContext()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetContext(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetMeasureFunc(YGNode*, nint)"/>
    public void SetMeasureFunc(nint measureFunc)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetMeasureFunc(ptr, measureFunc);
    }

    /// <inheritdoc cref="Interop.YGNodeHasMeasureFunc(YGNode*)"/>
    public bool HasMeasureFunc()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeHasMeasureFunc(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetBaselineFunc(YGNode*, nint)"/>
    public void SetBaselineFunc(nint baselineFunc)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetBaselineFunc(ptr, baselineFunc);
    }

    /// <inheritdoc cref="Interop.YGNodeHasBaselineFunc(YGNode*)"/>
    public bool HasBaselineFunc()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeHasBaselineFunc(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetIsReferenceBaseline(YGNode*, bool)"/>
    public void SetIsReferenceBaseline(bool isReferenceBaseline)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetIsReferenceBaseline(ptr, isReferenceBaseline);
    }

    /// <inheritdoc cref="Interop.YGNodeIsReferenceBaseline(YGNode*)"/>
    public bool IsReferenceBaseline()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeIsReferenceBaseline(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetNodeType(YGNode*, YGNodeType)"/>
    public void SetNodeType(YGNodeType nodeType)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetNodeType(ptr, nodeType);
    }

    /// <inheritdoc cref="Interop.YGNodeGetNodeType(YGNode*)"/>
    public YGNodeType GetNodeType()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetNodeType(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeSetAlwaysFormsContainingBlock(YGNode*, bool)"/>
    public void SetAlwaysFormsContainingBlock(bool alwaysFormsContainingBlock)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeSetAlwaysFormsContainingBlock(ptr, alwaysFormsContainingBlock);
    }

    /// <inheritdoc cref="Interop.YGNodeGetAlwaysFormsContainingBlock(YGNode*)"/>
    public bool GetAlwaysFormsContainingBlock()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeGetAlwaysFormsContainingBlock(ptr);
    }

    // --- Layout Methods

    /// <inheritdoc cref="Interop.YGNodeLayoutGetLeft(YGNode*)"/>
    public float GetComputedLeft()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetLeft(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetTop(YGNode*)"/>
    public float GetComputedTop()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetTop(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetRight(YGNode*)"/>
    public float GetComputedRight()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetRight(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetBottom(YGNode*)"/>
    public float GetComputedBottom()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetBottom(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetWidth(YGNode*)"/>
    public float GetComputedWidth()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetWidth(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetHeight(YGNode*)"/>
    public float GetComputedHeight()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetHeight(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetDirection(YGNode*)"/>
    public YGDirection GetComputedDirection()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetDirection(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetHadOverflow(YGNode*)"/>
    public bool GetHadOverflow()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetHadOverflow(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetMargin(YGNode*, YGEdge)"/>
    public float GetComputedMargin(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetMargin(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetBorder(YGNode*, YGEdge)"/>
    public float GetComputedBorder(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetBorder(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeLayoutGetPadding(YGNode*, YGEdge)"/>
    public float GetComputedPadding(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeLayoutGetPadding(ptr, edge);
    }

    // --- Style Methods

    /// <inheritdoc cref="Interop.YGNodeCopyStyle(YGNode*, YGNode*)"/>
    public void CopyStyle(YGNode* srcNode)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeCopyStyle(ptr, srcNode);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetDirection(YGNode*, YGDirection)"/>
    public void SetDirection(YGDirection value)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetDirection(ptr, value);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetDirection(YGNode*)"/>
    public YGDirection GetDirection()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetDirection(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlexDirection(YGNode*, YGFlexDirection)"/>
    public void SetFlexDirection(YGFlexDirection flexDirection)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlexDirection(ptr, flexDirection);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetFlexDirection(YGNode*)"/>
    public YGFlexDirection GetFlexDirection()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetFlexDirection(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetJustifyContent(YGNode*, YGJustify)"/>
    public void SetJustifyContent(YGJustify justifyContent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetJustifyContent(ptr, justifyContent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetJustifyContent(YGNode*)"/>
    public YGJustify GetJustifyContent()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetJustifyContent(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetAlignContent(YGNode*, YGAlign)"/>
    public void SetAlignContent(YGAlign alignContent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetAlignContent(ptr, alignContent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetAlignContent(YGNode*)"/>
    public YGAlign GetAlignContent()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetAlignContent(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetAlignItems(YGNode*, YGAlign)"/>
    public void SetAlignItems(YGAlign alignItems)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetAlignItems(ptr, alignItems);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetAlignItems(YGNode*)"/>
    public YGAlign GetAlignItems()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetAlignItems(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetAlignSelf(YGNode*, YGAlign)"/>
    public void SetAlignSelf(YGAlign alignSelf)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetAlignSelf(ptr, alignSelf);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetAlignSelf(YGNode*)"/>
    public YGAlign GetAlignSelf()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetAlignSelf(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetPositionType(YGNode*, YGPositionType)"/>
    public void SetPositionType(YGPositionType positionType)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetPositionType(ptr, positionType);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetPositionType(YGNode*)"/>
    public YGPositionType GetPositionType()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetPositionType(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlexWrap(YGNode*, YGWrap)"/>
    public void SetFlexWrap(YGWrap flexWrap)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlexWrap(ptr, flexWrap);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetFlexWrap(YGNode*)"/>
    public YGWrap GetFlexWrap()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetFlexWrap(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetOverflow(YGNode*, YGOverflow)"/>
    public void SetOverflow(YGOverflow overflow)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetOverflow(ptr, overflow);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetOverflow(YGNode*)"/>
    public YGOverflow GetOverflow()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetOverflow(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetDisplay(YGNode*, YGDisplay)"/>
    public void SetDisplay(YGDisplay display)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetDisplay(ptr, display);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetDisplay(YGNode*)"/>
    public YGDisplay GetDisplay()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetDisplay(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlex(YGNode*, float)"/>
    public void SetFlex(float flex)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlex(ptr, flex);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetFlex(YGNode*)"/>
    public float GetFlex()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetFlex(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlexGrow(YGNode*, float)"/>
    public void SetFlexGrow(float flexGrow)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlexGrow(ptr, flexGrow);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetFlexGrow(YGNode*)"/>
    public float GetFlexGrow()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetFlexGrow(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlexShrink(YGNode*, float)"/>
    public void SetFlexShrink(float flexShrink)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlexShrink(ptr, flexShrink);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetFlexShrink(YGNode*)"/>
    public float GetFlexShrink()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetFlexShrink(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlexBasis(YGNode*, float)"/>
    public void SetFlexBasis(float flexBasis)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlexBasis(ptr, flexBasis);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlexBasisPercent(YGNode*, float)"/>
    public void SetFlexBasisPercent(float flexBasisPercent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlexBasisPercent(ptr, flexBasisPercent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetFlexBasisAuto(YGNode*)"/>
    public void SetFlexBasisAuto()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetFlexBasisAuto(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetFlexBasis(YGNode*)"/>
    public YGValue GetFlexBasis()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetFlexBasis(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetPosition(YGNode*, YGEdge, float)"/>
    public void SetPosition(YGEdge edge, float points)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetPosition(ptr, edge, points);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetPositionPercent(YGNode*, YGEdge, float)"/>
    public void SetPositionPercent(YGEdge edge, float percent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetPositionPercent(ptr, edge, percent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetPositionAuto(YGNode*, YGEdge)"/>
    public void SetPositionAuto(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetPositionAuto(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetPosition(YGNode*, YGEdge)"/>
    public YGValue GetPosition(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetPosition(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMargin(YGNode*, YGEdge, float)"/>
    public void SetMargin(YGEdge edge, float points)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMargin(ptr, edge, points);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMarginPercent(YGNode*, YGEdge, float)"/>
    public void SetMarginPercent(YGEdge edge, float percent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMarginPercent(ptr, edge, percent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMarginAuto(YGNode*, YGEdge)"/>
    public void SetMarginAuto(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMarginAuto(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetMargin(YGNode*, YGEdge)"/>
    public YGValue GetMargin(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetMargin(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetPadding(YGNode*, YGEdge, float)"/>
    public void SetPadding(YGEdge edge, float points)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetPadding(ptr, edge, points);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetPaddingPercent(YGNode*, YGEdge, float)"/>
    public void SetPaddingPercent(YGEdge edge, float percent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetPaddingPercent(ptr, edge, percent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetPadding(YGNode*, YGEdge)"/>
    public YGValue GetPadding(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetPadding(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetBorder(YGNode*, YGEdge, float)"/>
    public void SetBorder(YGEdge edge, float border)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetBorder(ptr, edge, border);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetBorder(YGNode*, YGEdge)"/>
    public float GetBorder(YGEdge edge)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetBorder(ptr, edge);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetGap(YGNode*, YGGutter, float)"/>
    public void SetGap(YGGutter gutter, float gapLength)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetGap(ptr, gutter, gapLength);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetGapPercent(YGNode*, YGGutter, float)"/>
    public void SetGapPercent(YGGutter gutter, float gapLength)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetGapPercent(ptr, gutter, gapLength);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetGap(YGNode*, YGGutter)"/>
    public float GetGap(YGGutter gutter)
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetGap(ptr, gutter);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetBoxSizing(YGNode*, YGBoxSizing)"/>
    public void SetBoxSizing(YGBoxSizing boxSizing)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetBoxSizing(ptr, boxSizing);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetBoxSizing(YGNode*)"/>
    public YGBoxSizing GetBoxSizing()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetBoxSizing(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetAspectRatio(YGNode*, float)"/>
    public void SetAspectRatio(float aspectRatio)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetAspectRatio(ptr, aspectRatio);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetAspectRatio(YGNode*)"/>
    public float GetAspectRatio()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetAspectRatio(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetWidth(YGNode*, float)"/>
    public void SetWidth(float points)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetWidth(ptr, points);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetWidthPercent(YGNode*, float)"/>
    public void SetWidthPercent(float percent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetWidthPercent(ptr, percent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetWidthAuto(YGNode*)"/>
    public void SetWidthAuto()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetWidthAuto(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetWidth(YGNode*)"/>
    public YGValue GetWidth()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetWidth(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetHeight(YGNode*, float)"/>
    public void SetHeight(float points)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetHeight(ptr, points);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetHeightPercent(YGNode*, float)"/>
    public void SetHeightPercent(float percent)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetHeightPercent(ptr, percent);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetHeightAuto(YGNode*)"/>
    public void SetHeightAuto()
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetHeightAuto(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetHeight(YGNode*)"/>
    public YGValue GetHeight()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetHeight(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMinWidth(YGNode*, float)"/>
    public void SetMinWidth(float minWidth)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMinWidth(ptr, minWidth);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMinWidthPercent(YGNode*, float)"/>
    public void SetMinWidthPercent(float minWidth)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMinWidthPercent(ptr, minWidth);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetMinWidth(YGNode*)"/>
    public YGValue GetMinWidth()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetMinWidth(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMinHeight(YGNode*, float)"/>
    public void SetMinHeight(float minHeight)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMinHeight(ptr, minHeight);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMinHeightPercent(YGNode*, float)"/>
    public void SetMinHeightPercent(float minHeight)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMinHeightPercent(ptr, minHeight);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetMinHeight(YGNode*)"/>
    public YGValue GetMinHeight()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetMinHeight(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMaxWidth(YGNode*, float)"/>
    public void SetMaxWidth(float maxWidth)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMaxWidth(ptr, maxWidth);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMaxWidthPercent(YGNode*, float)"/>
    public void SetMaxWidthPercent(float maxWidth)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMaxWidthPercent(ptr, maxWidth);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetMaxWidth(YGNode*)"/>
    public YGValue GetMaxWidth()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetMaxWidth(ptr);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMaxHeight(YGNode*, float)"/>
    public void SetMaxHeight(float maxHeight)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMaxHeight(ptr, maxHeight);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleSetMaxHeightPercent(YGNode*, float)"/>
    public void SetMaxHeightPercent(float maxHeight)
    {
        fixed (YGNode* ptr = &this)
            Interop.YGNodeStyleSetMaxHeightPercent(ptr, maxHeight);
    }

    /// <inheritdoc cref="Interop.YGNodeStyleGetMaxHeight(YGNode*)"/>
    public YGValue GetMaxHeight()
    {
        fixed (YGNode* ptr = &this)
            return Interop.YGNodeStyleGetMaxHeight(ptr);
    }
}

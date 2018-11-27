﻿// ***********************************************************************
// Assembly         : Remarker
// Solution         : CommentPlus
// File name        : SmallQuestionFormat.cs
// Author           : Gil Yoder
// Created          : 08 29,  2014
//
// Last Modified By : Gil Yoder
// Last Modified On : 08 29, 2014
// ***********************************************************************

namespace YoderZone.Extensions.Remarker.FormatDefinitions
{
#region Imports

    using System.ComponentModel.Composition;

    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Utilities;

    using YoderZone.Extensions.Remarker.Utilities;

    #endregion

/// <summary>
///     A small question format.
/// </summary>
/// <seealso
///     cref="T:Microsoft.VisualStudio.Text.Classification.ClassificationFormatDefinition" />
[Name(Definitions.CommentQuestionSmallType)]
[UserVisible(true)]
[Order(After = Priority.High)]
[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames =
                        Definitions.CommentQuestionSmallType)]
public class SmallQuestionFormat : ClassificationFormatDefinition
{
    #region Constructors and Destructors

    /// <summary>
    ///     Initializes a new instance of the YoderZone.Extensions.SmallQuestionFormat
    ///     class.
    /// </summary>
    public SmallQuestionFormat()
    {
        this.DisplayName = "Remarker Question - Small (-)";
        this.IsBold = false;
        this.ForegroundColor = Resources.NormalQuestionColor;
        this.ForegroundCustomizable = true;
        this.BackgroundCustomizable = true;
    }

    #endregion
}
}
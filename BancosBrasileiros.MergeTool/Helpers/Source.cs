﻿// ***********************************************************************
// Assembly         : BancosBrasileiros.MergeTool
// Author           : guibr
// Created          : 06-01-2022
//
// Last Modified By : guibr
// Last Modified On : 06-01-2022
// ***********************************************************************
// <copyright file="Source.cs" company="Guilherme Branco Stracini ME">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace BancosBrasileiros.MergeTool.Helpers
{
    /// <summary>
    /// Enum Source
    /// </summary>
    internal enum Source
    {
        /// <summary>
        /// The base
        /// </summary>
        Base,

        /// <summary>
        /// The change log
        /// </summary>
        ChangeLog,

        /// <summary>
        /// The CTC
        /// </summary>
        Ctc,

        /// <summary>
        /// The PCPS
        /// </summary>
        Pcps,

        /// <summary>
        /// The siloc
        /// </summary>
        Siloc,

        /// <summary>
        /// The sitraf
        /// </summary>
        Sitraf,

        /// <summary>
        /// The SLC
        /// </summary>
        Slc,

        /// <summary>
        /// The spi
        /// </summary>
        Spi
    }
}
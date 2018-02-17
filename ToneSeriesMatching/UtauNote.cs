﻿using System.Runtime.InteropServices;

namespace ToneSeriesMatching
{
    /// <summary>
    /// UTAU スコア内の音符1つ
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    public struct UtauNote
    {
        /// <summary>
        /// 開始位置（4分音符 480 として計算）
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// 音高 [0, 11]
        /// </summary>
        public int NoteNumber { get; }

        public UtauNote(int position, int noteNumber)
        {
            this.Position = position;
            this.NoteNumber = noteNumber;
        }
    }
}

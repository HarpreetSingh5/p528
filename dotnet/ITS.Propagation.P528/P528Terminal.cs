﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Propagation
{
    /// <summary>
    /// Intermediate values for terminal geometry
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct P528Terminal
    {
        /// <summary>
        /// Real terminal height
        /// </summary>
        public double h_r__km;

        /// <summary>
        /// Effective terminal height
        /// </summary>
        public double h_e__km;

        /// <summary>
        /// Terminal height used in model
        /// </summary>
        public double h__km;

        /// <summary>
        /// Internal terminal param.  See Recommendation text.
        /// </summary>
        public double delta_h__km;

        /// <summary>
        /// Ray traced horizon distance
        /// </summary>
        public double d_r__km;

        /// <summary>
        /// Horizon distance used in model
        /// </summary>
        public double d__km;

        /// <summary>
        /// Central angle between the terminal and its smooth earth horizon
        /// </summary>
        public double phi__rad;

        /// <summary>
        /// Incident angle of the grazing ray at the terminal
        /// </summary>
        public double theta__rad;
    };
}
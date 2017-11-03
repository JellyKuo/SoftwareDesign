using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinate
{
    /// <summary>
    /// 簡單的二維、三維座標類別
    /// </summary>
    public class Pos
    {
        /// <summary>
        /// 座標的X值
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// 座標的Y值
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// 座標的Z值
        /// </summary>
        public int Z
        {
            get
            {
                if (ThreeDimensional)
                    return Z;
                else
                    throw new InvalidOperationException("這不是一個三維的座標");
            }
            set
            {
                if (ThreeDimensional)
                    Z = value;
                else
                    throw new InvalidOperationException("這不是一個三維的座標");
            }
        }
        /// <summary>
        /// 座標是否為三維坐標
        /// </summary>
        public bool ThreeDimensional { get; }
        /// <summary>
        /// 建構一個二維的座標
        /// </summary>
        /// <param name="X">座標的X值</param>
        /// <param name="Y">座標的Y值</param>
        public Pos(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            ThreeDimensional = false;
        }
        /// <summary>
        /// 建構一個三維的座標
        /// </summary>
        /// <param name="X">座標的X值</param>
        /// <param name="Y">座標的Y值</param>
        /// <param name="Z">座標的Z值</param>
        public Pos(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            ThreeDimensional = true;
        }
    }
}

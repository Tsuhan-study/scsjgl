using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maticsoft.Model
{
    /// <summary>
    /// 键盘类
    /// </summary>
    public class KeyBoard
    {
        //定义泛型对象存放键
        List<Keys> keys = new List<Keys>();

        /// <summary>
        /// 定义构造方法，清空所有的键
        /// </summary>
        public KeyBoard()
        {
            //清空所有的键
            keys.Clear();
        }

        //声明KeyBoard类的对象
        private static KeyBoard instance;
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <returns></returns>
        public static KeyBoard CreateInstance()
        {
            if (instance == null)
            {
                instance = new KeyBoard();
            }
            return instance;
        }

        /// <summary>
        /// 清空所有键
        /// </summary>
        public void ClearKeys()
        {
            keys.Clear();
        }

        /// <summary>
        /// 定义方法判断键是否被按下
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool IsKeyDown(Keys key)
        {
            //调用方法判断键是否被按下，返回判断的结果
            return keys.Contains(key);
        }

        /// <summary>
        /// 定义方法将按下的键添加到泛型对象
        /// </summary>
        /// <param name="key"></param>
        public void KeyDown(Keys key)
        {
            //判断泛型对象中是否有该键
            if (!keys.Contains(key))
            {
                //如果泛型对象中没有该键，将该键添加到泛型对象
                keys.Add(key);
            }
        }

        /// <summary>
        /// 定义方法将弹起的键移除
        /// </summary>
        /// <param name="key"></param>
        public void KeyUp(Keys key)
        {
            //判断泛型对象中是否有该键
            if (keys.Contains(key))
            {
                //如果有该键，调用方法移除该键
                keys.Remove(key);
            }
        }

    }
}

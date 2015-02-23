﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IWshRuntimeLibrary;

namespace StaticFileUpload.Common
{
    public class ShortCutsUtil
    {
        /// <summary>
        /// 获取快捷方式的真实路径
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetTarget(string path)
        {
            IWshShortcut _shortcut = null;
            IWshShell_Class shell = new IWshShell_Class();
            if (System.IO.File.Exists(path) == true)
                _shortcut = shell.CreateShortcut(path) as IWshShortcut;//在vs2010中CreateShortcut返回dynamic 类型
            return _shortcut.TargetPath;
        }
    }
}

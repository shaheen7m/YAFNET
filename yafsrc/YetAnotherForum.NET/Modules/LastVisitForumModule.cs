﻿/* YetAnotherForum.NET
 * Copyright (C) 2006-2010 Jaben Cargman
 * http://www.yetanotherforum.net/
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */
namespace YAF.Modules
{
  using System;

  using YAF.Core;
  using YAF.Types.Attributes;
  using YAF.Types.Interfaces; using YAF.Types.Constants; using YAF.Types.Constants;
  using YAF.Core.Services;
  using YAF.Utils;
  using YAF.Types.Interfaces;

  /// <summary>
  /// Summary description for Last Visit Module
  /// </summary>
  [YafModule("Last Visit Module", "Tiny Gecko", 1)]
  public class LastVisitForumModule : SimpleBaseForumModule
  {
    /// <summary>
    /// The init before page.
    /// </summary>
    public override void InitBeforePage()
    {
      PageContext.PagePreLoad += PageContext_PagePreLoad;
    }

    /// <summary>
    /// The page context_ page pre load.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    private void PageContext_PagePreLoad(object sender, EventArgs e)
    {
      if (!PageContext.IsGuest && PageContext.Page["PreviousVisit"] != DBNull.Value && !PageContext.Get<IYafSession>().HasLastVisit)
      {
        YafContext.Current.Get<IYafSession>().LastVisit = Convert.ToDateTime(PageContext.Page["PreviousVisit"]);
        YafContext.Current.Get<IYafSession>().HasLastVisit = true;
      }
      else if (YafContext.Current.Get<IYafSession>().LastVisit == DateTime.MinValue)
      {
        YafContext.Current.Get<IYafSession>().LastVisit = DateTime.UtcNow;
      }
    }
  }
}
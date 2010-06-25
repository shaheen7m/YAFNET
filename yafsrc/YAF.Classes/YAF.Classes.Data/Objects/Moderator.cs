﻿/* Yet Another Forum.NET
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
namespace YAF.Classes.Data
{
  /// <summary>
  /// The moderator.
  /// </summary>
  public class Moderator
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Moderator"/> class.
    /// </summary>
    /// <param name="forumID">
    /// The forum id.
    /// </param>
    /// <param name="moderatorID">
    /// The moderator id.
    /// </param>
    /// <param name="name">
    /// The name.
    /// </param>
    /// <param name="isGroup">
    /// The is group.
    /// </param>
    public Moderator(long forumID, long moderatorID, string name, bool isGroup)
    {
      ForumID = forumID;
      ModeratorID = moderatorID;
      Name = name;
      IsGroup = isGroup;
    }

    /// <summary>
    /// Gets or sets ForumID.
    /// </summary>
    public long ForumID
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets ModeratorID.
    /// </summary>
    public long ModeratorID
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name
    {
      get;
      set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether IsGroup.
    /// </summary>
    public bool IsGroup
    {
      get;
      set;
    }
  }
}
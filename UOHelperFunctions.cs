﻿/*
 * Copyright (C) 2011 - 2012 James Kidd
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uoNet
{
    
    public class UOHelperFunctions
    {
        public IntPtr UOHandle;
        #region Client Variables

        #region Character Info
        public int CharPosX
        {
            get
            {
                return GetInt("CharPosX");
            }
        }
        public int CharPosY
        {
            get
            {
                return GetInt("CharPosY");
            }
        }
        public int CharPosZ
        {
            get
            {
                return GetInt("CharPosZ");
            }
        }
        public int CharDir
        {
            get
            {
                return GetInt("CharDir");
            }
        }
        public int CharID
        {
            get
            {
                return GetInt("CharID");
            }
        }
        public int CharType
        {
            get
            {
                return GetInt("CharType");
            }
        }
        public int CharStatus
        {
            get
            {
                return GetInt("CharStatus");
            }
        }
        public int BackpackID
        {
            get
            {
                return GetInt("BackpackID");
            }
        }
#endregion

        #region Status Info
        public string CharName
        {
            get
            {
                return GetString("CharName");
            }
        }

        public int Sex
        {
            get
            {
                return GetInt("Sex");
            }
        }

        public int Str
        {
            get
            {
                return GetInt("Str");
            }
        }

        public int Dex
        {
            get
            {
                return GetInt("Dex");
            }
        }

        public int Int
        {
            get
            {
                return GetInt("Int");
            }
        }

        public int Hits
        {
            get
            {
                return GetInt("Hits");
            }
        }

        public int MaxHits
        {
            get
            {
                return GetInt("MaxHits");
            }
        }

        public int Stamina
        {
            get
            {
                return GetInt("Stamina");
            }
        }

        public int MaxStam
        {
            get
            {
                return GetInt("MaxStam");
            }
        }

        public int Mana
        {
            get
            {
                return GetInt("Mana");
            }
        }

        public int MaxMana
        {
            get
            {
                return GetInt("MaxMana");
            }
        }

        public int MaxStats
        {
            get
            {
                return GetInt("MaxStats");
            }
        }

        public int Luck
        {
            get
            {
                return GetInt("Luck");
            }
        }

        public int Weight
        {
            get
            {
                return GetInt("Weight");
            }
        }

        public int MaxWeight
        {
            get
            {
                return GetInt("MaxWeight");
            }
        }

        public int MinDmg
        {
            get
            {
                return GetInt("MinDmg");
            }
        }

        public int MaxDmg
        {
            get
            {
                return GetInt("MaxDmg");
            }
        }

        public int Gold
        {
            get
            {
                return GetInt("Gold");
            }
        }

        public int Followers
        {
            get
            {
                return GetInt("Followers");
            }
        }

        public int MaxFol
        {
            get
            {
                return GetInt("MaxFol");
            }
        }

        public int AR
        {
            get
            {
                return GetInt("AR");
            }
        }

        public int FR
        {
            get
            {
                return GetInt("FR");
            }
        }

        public int CR
        {
            get
            {
                return GetInt("CR");
            }
        }

        public int PR
        {
            get
            {
                return GetInt("PR");
            }
        }

        public int ER
        {
            get
            {
                return GetInt("ER");
            }
        }

        public int TP
        {
            get
            {
                return GetInt("TP");
            }
        }
        #endregion

        #region Container Info
        public int ContID
        {
            get
            {
                return GetInt("ContID");
            }
        }
        public int ContType
        {
            get
            {
                return GetInt("ContType");
            }
        }
        public int ContKind
        {
            get
            {
                return GetInt("ContKind");
            }
        }
        public string ContName
        {
            get
            {
                return GetString("ContName");
            }
        }
        public int ContPosX
        {
            get
            {
                return GetInt("ContPosX");
            }
        }
        public int ContPosY
        {
            get
            {
                return GetInt("ContPosY");
            }
        }
        public int ContSizeX
        {
            get
            {
                return GetInt("ContSizeX");
            }
        }
        public int ContSizeY
        {
            get
            {
                return GetInt("ContSizeY");
            }
        }
        public int NextCPosX
        {
            get
            {
                return GetInt("NextCPosX");
            }
            set
            {
                SetInt("NextCPosX", value);
            }
        }
        public int NextCPosY
        {
            get
            {
                return GetInt("NextCPosY");
            }
            set
            {
                SetInt("NextCPosY", value);
            }
        }


        #endregion

        #region CharInfo

        #endregion
        public int LObjectID
        {
            get
            {
                return GetInt("LObjectID");
            }
            set
            {
                SetInt("LObjectID", value);
            }
        }
        #endregion
       

        #region GetterSetterHelpers
        private bool GetBoolean(string command)
        {
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Get");
            UO.PushStrVal(UOHandle, command);
            var result = UO.Execute(UOHandle);
            if (result == 0)
                return UO.GetBoolean(UOHandle, 1);
            else
                return false;
        }

        private void SetBoolean(string command, Boolean value)
        {
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Set");
            UO.PushStrVal(UOHandle, command);
            UO.PushBoolean(UOHandle, value);
            UO.Execute(UOHandle);
        }

        private int GetInt(string command)
        {
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Get");
            UO.PushStrVal(UOHandle, command);
            var result = UO.Execute(UOHandle);
            if (result == 0)
                return UO.GetInteger(UOHandle, 1);
            else
                return 0;
        }

        private void SetInt(string command,int value)
        {
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Set");
            UO.PushStrVal(UOHandle, command);
            UO.PushInteger(UOHandle, value);
            UO.Execute(UOHandle);
        }

        private string GetString(string command)
        {
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Get");
            UO.PushStrVal(UOHandle, command);
            var result = UO.Execute(UOHandle);
            if (result == 0)
                return UO.GetString(UOHandle, 1);
            else
                return null;//Return Blank string instead?
        }
        private void SetString(string command, string value)
        {
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Set");
            UO.PushStrVal(UOHandle, command);
            UO.PushStrVal(UOHandle, value);
            UO.Execute(UOHandle);
        }
        #endregion
        #region OpenClose
        public void Close()
        {
            UO.Close(UOHandle);
        }
        public void Open()
        {
            UOHandle = UO.Open();
            var ver = UO.Version();
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Set");
            UO.PushStrVal(UOHandle, "CliNr");
            UO.PushInteger(UOHandle, 1);
        }
        public void Open(int CliNr)
        {
            UOHandle = UO.Open();
            var ver = UO.Version();
            UO.SetTop(UOHandle, 0);
            UO.PushStrVal(UOHandle, "Set");
            UO.PushStrVal(UOHandle, "CliNr");
            UO.PushInteger(UOHandle, CliNr);
        }
        #endregion
        
    }
}

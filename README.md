/*	3dpBurner Image2Gcode. A Image to GCODE converter for GRBL based devices.
    This file is part of 3dpBurner mage2Gcode application.
    Copyright (C) 2014-2015  Adrian V. J. (villamany) contact: villamany@gmail.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

GitHub notes:
The master branch contain the development version.
Check the "Releases" for release versions and .exe files.

//-------------------------------------------------------
//-------------------- Changelog ------------------------
//-------------------------------------------------------

Image2GCode has been modified by Leo69 for use on Marlin firmware for MPCNC

Additional modifications made by Bryan (Uthayne)
    Profiles
    Origin
    
Revised interpolate function to allow 4 place decimal laser power values instead of integers. Will provide better grayscale resolution on high powered lasers with small working range of power values. Leo-69

Minor bug fixes and improvements -Bryan (Uthayne)

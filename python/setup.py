from distutils.core import setup
import py2exe

data_files = [('', [r'G1.ico'])]

setup(
windows = [
{
"script": "Gcalculator.py",
"icon_resources": [(1, "G1.ico")],
}
],
data_files = data_files
)
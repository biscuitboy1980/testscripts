from distutils.core import setup
import py2exe

setup(windows=[
	{
		"script": "GCalculator.py",
		"icon_resources": [(1, "G.ico")]
	}
],
)
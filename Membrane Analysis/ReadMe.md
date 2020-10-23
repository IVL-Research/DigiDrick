This repository contains all code to perform the membrane filtration analysis in DigiDrick.

The repository contains:
- MembraneAnalysis : Main Jupyter Notebook to perform calculations and plots
- vivab_data_import: Jupyter Notebook to import data from txt and xls files and create data files to be imported by MembraneAnalysis
- ObsVarDef: Used for variable settings (min/max limits, median filtering etc) and variable information, imported by MembraneAnalysis.
- python_environment: YML file containing the setup for python environment

How to use
1. Download the repository files
2. Install Python through for example Anaconda (https://www.anaconda.com/products/individual)
3. Create environment by importing the python_environment file  (https://docs.anaconda.com/anaconda/navigator/tutorials/manage-environments/)
4. Make sure that your data files are in the format of the example files in this repository
5. Create your ObsVarDef-file describing the data
6. Start Jupyter Notebook (https://pythonforundergradengineers.com/opening-a-jupyter-notebook-on-windows.html)
7. Open vivab_data_import.ipynb and run the cells
8. Open MembraneAnalysis.ipynb and run the cells

## @package calculateDModX
# This module loads a previously pickled 'StoredModel'-object and calculates DModX.
# @param model_name Name of PLS model file
# @param X Input X array
# @return DModX Normalized distance to model X

import sys
import pickle
import numpy as np


## Class to store model attributes from PLS model. Enables results from PLS model to be stored as a pickled object.
class StoredModel:

    def __init__(self, coefficients, loadings, rotations, residual_var, x_mean, x_std):

        self.coefficients = coefficients
        self.loadings = loadings
        self.rotations = rotations
        self.residual_var = residual_var
        self.n_components = loadings.shape[1]
        self.x_mean = x_mean
        self.x_std = x_std


model_name = sys.argv[1]  # Name of model to import
x = sys.argv[2]  # Input X vector

input_array = list(map(float, x[1:-1].split(',')))  # Convert input to python array
pls_model = pickle.load(open(model_name, 'rb'))  # Load model
X = (np.array(input_array) - pls_model.x_mean) / pls_model.x_std  # Scale X
scores = np.dot(X, pls_model.rotations)  # Calculate Scores
residual = X - np.dot(scores, np.transpose(pls_model.loadings))  # Calculate Residual
dmodx_normalized = np.sqrt(np.nansum(residual**2) / pls_model.residual_var)  # Normalized DModX
print(dmodx_normalized)  # Return DModX

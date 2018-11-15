## @package load_model
# Reads a serialized PLS model file and returns the coefficient variables.
# @param model_name Name of PLS model file
# @returns Model coefficients list
import sys
import pickle


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


model_name = sys.argv[1]  # First system argument
pls_model = pickle.load(open(model_name, 'rb'))  # Load model
flat_coefficients = [item for sublist in pls_model.coefficients for item in sublist]  # Flatten coefficient list
print(flat_coefficients)  # Return coefficient list




import copy

def det_all(matrix):
    A11 = matrix[1][1] * matrix[2][2] - matrix[2][1] * matrix[1][2]
    A12 = matrix[1][0] * matrix[2][2] - matrix[2][0] * matrix[1][2]
    A13 = matrix[1][0] * matrix[2][1] - matrix[2][0] * matrix[1][1]
    d = matrix[0][0] *  A11 - matrix[0][1] * A12 + matrix[0][2] * A13
    return d

def det_x(matrix, constants):
    copy_matryx = copy.deepcopy(matrix)
    b1 = constants[0]
    b2 = constants[1]
    b3 = constants[2]
    copy_matryx[0][0], copy_matryx[1][0], copy_matryx[2][0] = b1,  b2,  b3
    matrix_x = det_all(copy_matryx)
    return matrix_x

def det_y(matrix, constants):
    copy_matryx = copy.deepcopy(matrix)
    b1 = constants[0]
    b2 = constants[1]
    b3 = constants[2]
    copy_matryx[0][1], copy_matryx[1][1], copy_matryx[2][1] = b1,  b2,  b3
    matrix_y = det_all(copy_matryx)
    return matrix_y

def det_z(matrix, constants):
    copy_matryx = copy.deepcopy(matrix)
    b1 = constants[0]
    b2 = constants[1]
    b3 = constants[2]
    copy_matryx[0][2], copy_matryx[1][2], copy_matryx[2][2] = b1,  b2,  b3
    matrix_z = det_all(copy_matryx)
    return matrix_z

matrix = [[7, 2, 3], [10, -6, 4], [5, -7, 3]]
constants = [15, 30, 21]

x = det_x(matrix, constants) / det_all(matrix)
y = det_y(matrix, constants) / det_all(matrix)
z = det_z(matrix, constants) / det_all(matrix)

print('x =', x, 'y =', y, 'z =', z)
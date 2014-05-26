package sudokuSolver;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class SudokuSolver {
	// TODO: removing magic numbers. They must be taken from file.
	private static int[][] matrix = new int[9][9];
	private static int[][] solvedPuzzle = matrix.clone();
	private static int rows = 9;
	private static int cols = 9;

	public static int[][] solvePuzzle(File puzzle) throws FileNotFoundException {
		loadSudokuFromFile(puzzle);
		solve(0, 0);

		return solvedPuzzle;
	}

	private static void loadSudokuFromFile(File f) throws FileNotFoundException {
		Scanner input = new Scanner(f);
		while (input.hasNextLine()) {
			for (int i = 0; i < matrix.length; i++) {
				for (int j = 0; j < matrix[i].length; j++) {
					matrix[i][j] = input.nextInt();
				}
			}
		}

		input.close();
	}

	private static void solve(int row, int col) {
		if (row >= rows) {
			copyMatrix(matrix, solvedPuzzle);
			return;
		}

		if (matrix[row][col] != 0) {
			next(row, col);
		} else {
			for (int num = 1; num <= matrix.length; num++) {
				if (allChecks(row, col, num)) {
					matrix[row][col] = num;
					next(row, col);
				}
			}
			matrix[row][col] = 0;
		}
	}

	private static void next(int row, int col) {
		if (col < cols - 1) {
			solve(row, col + 1);
		} else {
			solve(row + 1, 0);
		}
	}

	private static void copyMatrix(int[][] source, int[][] destination) {
		for (int r = 0; r < source.length; r++) {
			destination[r] = new int[source[r].length];

			for (int c = 0; c < source[r].length; c++) {
				destination[r][c] = source[r][c];
			}
		}
	}

	private static boolean checkCol(int col, int number) {
		for (int i = 0; i < matrix.length; i++) {
			if (matrix[i][col] == number) {
				return false;
			}
		}

		return true;
	}

	private static boolean checkRow(int row, int number) {
		for (int i = 0; i < matrix[row].length; i++) {
			if (matrix[row][i] == number) {
				return false;
			}
		}
		return true;
	}

	private static boolean checkSubMat(int row, int col, int number) {
		int subQuadrantLength = (int) Math.sqrt(rows);
		row = (row / subQuadrantLength) * subQuadrantLength;
		col = (col / subQuadrantLength) * subQuadrantLength;
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				if (matrix[row + i][col + j] == number) {
					return false;
				}
			}
		}
		return true;
	}

	private static boolean allChecks(int row, int col, int number) {

		return checkCol(col, number) && checkRow(row, number)
				&& checkSubMat(row, col, number);
	}
}
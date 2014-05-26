package sudokuSolver;

import java.io.File;
import java.io.FileNotFoundException;

public class Program {
	public static void main(String[] args) {
		long start = System.currentTimeMillis();

		try {
			printMatrix(SudokuSolver.solvePuzzle(new File("sud3.txt")));
		} catch (FileNotFoundException e) {
			System.out.println(e.getMessage());
		}

		long end = System.currentTimeMillis();
		System.out.print("service time: " + (end - start) / 1000.0 + "s");
		long memory = Runtime.getRuntime().totalMemory() - Runtime.getRuntime().freeMemory();
		System.out.printf("\nMemory used: %d KB", memory / 1024);
	}
	
	private static void printMatrix(int[][] matrix) {
		StringBuilder output = new StringBuilder();
		
		for(int r = 0; r < matrix.length; r++) {
			output.delete(0, output.length());
			for(int c = 0; c < matrix[r].length; c++) {
				output.append(matrix[r][c]);
				if(c < matrix[r].length - 1) {
					output.append(" ");
				}
			}
			System.out.println(output);
		}
	}
}

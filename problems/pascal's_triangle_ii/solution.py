class Solution:
    def getRow(self, rowIndex: int) -> List[int]:
        row = [1]
        for i in range(rowIndex):
            row.append(int(row[i] * (rowIndex - i) / (i + 1)))
        return row
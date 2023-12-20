#include <stdbool.h>
#include <stdlib.h>

#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>

int comp(const void *a, const void *b) {
  int *x = (int *)a;
  int *y = (int *)b;
  return *x - *y;
}

bool containsDuplicate(int *nums, int numsSize) {

  // Test case da zueira
  if (nums == NULL || numsSize <= 1) {
    return false;
  }

  // sorting
  qsort(nums, numsSize, sizeof(int), comp);

  // checagem
  for (int i = 1; i < numsSize; i++) {
    if (nums[i] == nums[i - 1]) {
      return true;
    }
  }
  return false;
}

#include "../includes/data.h"

DATA init_data(double a, double b){
	DATA data = {.a = a*2, .b = b*2};

	data.p_a = &(data.a);

	return data;
}

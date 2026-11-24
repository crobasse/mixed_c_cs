#pragma once

typedef struct {
	double a;
	double b;
	double *p_a;
} DATA;



DATA init_data(double a, double b);
